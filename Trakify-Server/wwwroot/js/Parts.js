$(function () {
    $.ajax({
        type: 'GET',
        url: '/Parts/_Parts',
        contentType: 'application/json',
        success: function (data) {
            $('#divParts').html(data);
        },
        complete: function () {
            $('#tblParts').DataTable();
        },
    });

    $('#PartFileUpload').change(function (e) {
        $('#PartHiddenFileUploadPath').val('');
        var fileName = e.target.files[0];
        var formData = new FormData();
        formData.append('files', fileName);
        var reader = new FileReader();
        reader.onload = function (e) {
            document.getElementById("preview").src = e.target.result;
        };

        $.ajax({
            url: '/FileUploader/UploadFile',
            type: 'POST',
            data: formData,
            processData: false,  // tell jQuery not to process the data
            contentType: false,  // tell jQuery not to set contentType
            success: function (result) {
                $('#PartHiddenFileUploadPath').val(result.fileNames[0]);
            },
            error: function (jqXHR) {
            },
            complete: function (jqXHR, status) {
            }
        });
        reader.readAsDataURL(this.files[0]);
    });
});
$(document).on("click", ".browse", function () {
    var file = $(this).parents().find(".file");
    file.trigger("click");
});
var Parts = {

    Reset: function () {
        $('#hdPartsID').val('');
        $('#PartCategory').val('');
        $('#PartQuantity').val('');
        $('#SerializedPartYes').val('');
        $('#PartSerial').val('');
        $('#PartName').val('');
        $('#PartBrand').val('');
        $('#PartLocation').val('');
        $('#PartDescription').val('');
        $('#PartSupplier').val('');
        $('#PartCost').val('');
        $('#PartMinimumReorderLevel').val('');
        $('#PartMarkup').val('');
        $('#PartColor').val('');
        $('#PartSpiffAmount').val('');
        $('#PartHiddenFileUploadPath').val('');
        $('#sub').show();
        $('#myModalLabel').html('Create');
        $('#spnName').text('');
        $('#spnName').hide();
        $('#sub').html('Create');
        $('#preview').attr('src', 'https://placehold.it/80x80');
        Parts.LoadPartDropdown(null);

    },
    OpenParts: function () {
        Parts.Reset();
        Parts.GetPartVendor();
        $('#submitVendor').show();
        $('#PartForm').modal('show');
    },
    OpenCategoryPopup: function () {

        //Parts.Reset();
        //$('#PartForm').hide();
        //$('#headerContractForm').hide();
        $('#PartCategoryModal').show();
        $('#PartCategoryForm').modal('show');
    },

    GetPartVendor: function () {
        $.ajax({
            type: "GET",
            url: "/Parts/GetPartVendorDetails",
            contentType: "application/json",
            success: function (response) {
                $('#PartFormVendor').empty().append('<option selected="selected" value="0">PartVendor</option>');
                for (var i = 0; i < response.length; i++) {
                    $('#PartFormVendor').append($("<option></option>").val(response[i].id).html(response[i].type));
                }
            }
        });
    },
    LoadPartDropdown: function (id) {
        debugger;
        SiteSystem.LoadDropDown('PartCategory', 'PartFormCategory', null, id, null);
        SiteSystem.LoadDropDown('PartVendor', 'PartFormVendor', null, id, null);
    },
    GetPartData: function () {
        debugger;
        IsSerializedPart = true;
        var SerializedStatus = $("input[name='SerializedPart']:checked").val();
        if (SerializedStatus == true || SerializedStatus == "true") {
            IsSerializedPart = true;
        } else {
            IsSerializedPart = false;
        }
        var flag = true;
        var data =
        {
            Id: $('#hdPartsID').val(),
            Category: $('#PartCategory').val(),
            IsSerializedPart: IsSerializedPart,
            Quantity: $('#PartQuantity').val(),
            Serial: $('#PartSerial').val(),
            Name: $('#PartName').val(),
            Brand: $('#PartBrand').val(),
            Location: $('#PartLocation').val(),
            Description: $('#PartDescription').val(),
            Supplier: $('#PartSupplier').val(),
            Cost: $('#PartCost').val(),
            MinimumReorderLevel: $('#PartMinimumReorderLevel').val(),
            Markup: $('#PartMarkup').val(),
            PartPhoto: $('#PartHiddenFileUploadPath').val(),
            Color: $('#PartColor').val(),
            SpiffAmount: $('#PartSpiffAmount').val(),
            Vendors: $('#PartFormVendor').val()
        }

        //if (data.Category == null || data.Category == '') {
        //    $('#spnCategory').text('Category is required');
        //    $("#spnCategory").show();
        //    flag = false;
        //}
        //else {
        //    $('#spnCategory').text('');
        //    $('#spnCategory').hide();
        //}
        if (data.Quantity == null || data.Quantity == '') {
            $('#spnQuantity').text('Quantity is required');
            $("#spnQuantity").show();
            flag = false;
        }
        else {
            $('#spnQuantity').text('');
            $('#spnQuantity').hide();
        }
        if (data.Serial == null || data.Serial == '') {
            $('#spnSerial').text('Serial is required');
            $("#spnSerial").show();
            flag = false;
        }
        else {
            $('#spnSerial').text('');
            $('#spnSerial').hide();
        }
        if (data.Name == null || data.Name == '') {
            $('#spnName').text('Name is required');
            $("#spnName").show();
            flag = false;
        }
        else {
            $('#spnName').text('');
            $('#spnName').hide();
        }
        if (data.Brand == null || data.Brand == '') {
            $('#spnBrand').text('Brand is required');
            $("#spnBrand").show();

        }
        else {
            $('#spnBrand').text('');
            $('#spnBrand').hide();
        }
        if (data.Location == null || data.Location == '') {
            $('#spnLocation').text('Location is required');
            $("#spnLocation").show();
            flag = false;

        }
        else {
            $('#spnLocation').text('');
            $('#spnLocation').hide();
        }

        if (data.Description == null || data.Description == '') {
            $('#spnDescription').text('Description is required');
            $("#spnDescription").show();
            flag = false;

        }
        else {
            $('#spnDescription').text('');
            $('#spnDescription').hide();
        }

        if (data.Supplier == null || data.Supplier == '') {
            $('#spnSupplier').text('Supplier is required');
            $("#spnSupplier").show();
            flag = false;
        }
        else {
            $('#spnSupplier').text('');
            $('#spnSupplier').hide();
        }
        if (data.Cost == null || data.Cost == '') {
            $('#spnCost').text('Cost is required');
            $("#spnCost").show();
            flag = false;
        }
        else {
            $('#spnCost').text('');
            $('#spnCost').hide();
        }
        if (data.MinimumReorderLevel == null || data.MinimumReorderLevel == '') {
            $('#spnMinimumReorderLevel').text('MinimumReorderLevel is required');
            $("#spnMinimumReorderLevel").show();
            flag = false;
        }
        else {
            $('#spnMinimumReorderLevel').text('');
            $('#spnMinimumReorderLevel').hide();
        }
        if (data.Markup == null || data.Markup == '') {
            $('#spnMarkup').text('Markup is required');
            $("#spnMarkup").show();
            flag = false;
        }
        else {
            $('#spnMarkup').text('');
            $('#spnMarkup').hide();
        }
        if (data.Color == null || data.Color == '') {
            $('#spnColor').text('Color is required');
            $("#spnColor").show();
            flag = false;
        }
        else {
            $('#spnColor').text('');
            $('#spnColor').hide();
        }
        debugger;
        if (flag == true) return data;
        else return null;
    },
    SaveCategoryName: function () {
        var actionLink = '/Parts/SaveCategoryParts';
        var obj =
        {
            Category: $('#PartCategoryName').val(),
        }
        if (obj != null) {
            $.ajax({
                type: 'POST',
                url: actionLink,
                data: obj,
                success: function (response) {
                    Parts.LoadPartDropdown(null);
                },
                complete: function () {
                    $('#PartCategoryForm').modal('hide');
                    //Courses.GetCourseData();
                }
            });
        }

    },

    Save: function () {
        var data = Parts.GetPartData();
        debugger;

        var actionLink = '/Parts/SaveParts';

        if (data.Id != null && data.Id != 0 && data.Id != '') {
            actionLink = '/Parts/UpdateParts';
        }
        if (data != null) {
            debugger;
            $.ajax({
                type: 'POST',
                url: actionLink,
                data: Parts.GetPartData(),
                success: function (data) {
                    Parts.LoadPartDropdown(null);
                },
                complete: function () {
                    $('#PartForm').modal('hide');
                    //Courses.GetCourseData();
                }
            });
        }
    },

    OpenEditParts: function (id) {
        $('#myModalLabel').html('Edit');
        $('#sub').html('Edit');
        $('#sub').show();
        $('#submitVendor').hide();
        $.ajax({
            type: 'Get',
            url: '/Parts/GetPartsData?id=' + id,
            success: function (data) {
                $('#hdPartsID').val(data.id);
                //$('#PartCategory').val(data.category);
                Parts.LoadPartDropdown(data.category);
                $("input[name=SerializedPart][value=" + data.isSerializedPart + "]").attr('checked', true);
                $('#SerializedPartYes').val(data.isSerializedPart);
                $('#PartSerial').val(data.serial);
                $('#PartName').val(data.name);
                $('#PartBrand').val(data.brand);
                $('#PartLocation').val(data.location);
                $('#PartDescription').val(data.description);
                $('#PartSupplier').val(data.supplier);
                $('#PartCost').val(data.cost);
                $('#PartMinimumReorderLevel').val(data.MinimumReorderLevel);
                $('#PartMarkup').val(data.markup);
                $('#PartColor').val(data.color);
                $('#PartSpiffAmount').val(data.spiffAmount);
                $('#preview').attr('src', location.protocol + "//" + location.host + '/img/' + data.partPhoto);
                $('#photopath').show();
                $('#PartForm').modal('show');

            }
        });
    },
};