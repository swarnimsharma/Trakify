$(function () {

    $.ajax({
        type: 'GET',
        url: '/Assets/_Assets',
        contentType: 'application/json',
        success: function (data) {
            debugger;
            $('#divAssests').html(data);
        },
        complete: function () {
            $('#tblAssets').DataTable();
        },
    });

    $.ajax({
        type: 'GET',
        url: '/Assets/_DetailsAssetsServiceList?Id=' + $('#hdAssetId').val(),
        contentType: 'application/json',
        success: function (data) {
            $('#divDetailsAssestsServiceList').html(data);
        }
    });
    $.ajax({
        type: 'GET',
        url: '/Assets/_AssetsServiceList?Id=' + $('#hdAssetId').val(),
        contentType: 'application/json',
        success: function (data) {
            $('#divAssestsServiceList').html(data);
        },
        complete: function () {
            $('#tblAssetMaintaneance').DataTable();
        }
    });


    $('#AssetFileUpload').change(function (e) {
        $('#AssetHiddenFileUploadPath').val('');
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
                $('#AssetHiddenFileUploadPath').val(result.fileNames[0]);
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
var Assets = {

    Reset: function () {
        $('#hdAssetID').val('');
        $('#AssetName').val('');
        $('#SerializedPartYes').val('');
        $('#AssetSerialNo').val('');
        $('#AssetBarcode').val('');
        $('#AssetAcquiredDate').val('');
        $('#AssetDescription').val('');
        $('#AssetBrandName').val('');
        $('#AssetLocation').val('');
        $('#AssetSubArea').val('');
        $('#AssetSupplierName').val('');
        $('#AssetCost').val('');
        $('#AssetColour').val('');
        $('#AssetTotalInhandQuantity').val('');
        $('#AssetHiddenFileUploadPath').val('');
        $('#sub').show();
        $('#myModalLabel').html('Create');
        $('#spnName').text('');
        $('#spnName').hide();
        $('#sub').html('Create');
        $('#preview').attr('src', 'https://placehold.it/80x80');
        Assets.ToggleTextBox(false);
    },
    OpenPopUp: function () {
        //Assets.Reset();
        $('#AssetForm').modal('show');
    },
   
    ResetAssetService: function () {
        $('#hdAssetServiceID').val('');
        $('#AssetTitle').val('');
        $('#AssetDescription').val('');
        $('#AssetCost').val('');
        $('#AssetServicedDate').val('');

    },

    OpenAssetService: function (Id) {
        //Assets.ResetAssetService();
        $('#hdAssetServiceID').val(Id);
        $('#AssetServiceForm').modal('show');
    },
   

    GetAssetService: function () {
        var flag = true;
        var data =
        {
            Title: $('#AssetTitle').val(),
            Description: $('#AssetDescription').val(),
            Cost: $('#AssetCost').val(),
            ServicedDate: $('#AssetServicedDate').val(),
            Trakify_AssetsServices: {
                Id: $('#hdAssetServiceID').val()
              
            }
            
        }
        if (data.Title == null || data.Title == '') {
            $('#spnTitle').text('Title is required');
            $("#spnTitle").show();
            flag = false;
        }
        else {
            $('#spnTitle').text('');
            $('#spnTitle').hide();
        }
        if (data.Description == null || data.Description == '') {
            $('#spnDescription').text('Description is required');
            $('#spnDescription').show();
            flag = false;
        }
        else {
            $('#spnDescription').text('');
            $('#spnDescription').hide();
        }
        if (data.Cost == null || data.Cost == '') {
            $('#spnCost').text('Cost is required');
            $('#spnCost').show();
            flag = false;
        }
        else {
            $('#spnCost').text('');
            $('#spnCost').hide();
        }
        if (data.ServicedDate == null || data.ServicedDate == '') {
            $('#spnServicedDate').text('ServicedDate is required');
            $("#spnServicedDate").show();
            flag = false;
        }
        else {
            $('#spnServicedDate').text('');
            $('#spnServicedDate').hide();
        }
        if (flag == true)
            return data;
        else return null;
    },
    SaveAssetService: function () {
        var data = Assets.GetAssetService();
        var actionLink = '/Assets/SaveAssetService';
        if (data != null) {
            debugger;
            $.ajax({
                type: 'POST',
                url: actionLink,
                data: Assets.GetAssetService(),
                success: function (data) {

                },
                complete: function () {
                    $('#AssetServiceForm').modal('hide');
                    //Courses.GetCourseData();
                }
            });
        }

    },

    GetAssetData: function () {
        IsSerializedAsset = true;
        var SerializedStatus = $("input[name='SerializedAsset']:checked").val();
        if (SerializedStatus == true || SerializedStatus == "true") {
            IsSerializedAsset = true;
        } else {
            IsSerializedAsset = false;
        }
        var flag = true;
        var data =
        {
            Id: $('#hdAssetID').val(),
            Name: $('#AssetName').val(),
            IsSerializedAsset: IsSerializedAsset,
            SerialNo: $('#AssetSerialNo').val(),
            AssetBarcode: $('#AssetBarcode').val(),
            AssetAcquiredDate: $('#AssetAcquiredDate').val(),
            Description: $('#AssetDescription').val(),
            BrandName: $('#AssetBrandName').val(),
            Location: $('#AssetLocation').val(),
            SubArea: $('#AssetSubArea').val(),
            SupplierName: $('#AssetSupplierName').val(),
            Cost: $('#AssetCost').val(),
            AssetColour: $('#AssetColour').val(),
            AssetPhoto: $('#AssetHiddenFileUploadPath').val(),
            TotalInhandQuantity: $('#AssetTotalInhandQuantity').val()
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
        if (data.SerialNo == null || data.SerialNo == '') {
            $('#spnSerial').text('serial is required');
            $("#spnSerial").show();
            flag = false;
        }
        else {
            $('#spnSerial').text('');
            $('#spnSerial').hide();
        }
        if (data.AssetBarcode == null || data.AssetBarcode == '') {
            $('#spnBarcode').text('Barcode is required');
            $("#spnBarcode").show();
            flag = false;
        }
        else {
            $('#spnBarcode').text('');
            $('#spnBarcode').hide();
        }
        if (data.AssetAcquiredDate == null || data.AssetAcquiredDate == '') {
            $('#spnAcquiredDate').text('AcquiredDate is required');
            $("#spnAcquiredDate").show();
            flag = false;
        }
        else {
            $('#spnAcquiredDate').text('');
            $('#spnAcquiredDate').hide();
        }
        if (data.TotalInhandQuantity == null || data.TotalInhandQuantity == '') {
            $('#spnTotalInhandQuantity').text('Quantity is required');
            $("#spnTotalInhandQuantity").show();

        }
        else {
            $('#spnTotalInhandQuantity').text('');
            $('#spnTotalInhandQuantity').hide();
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
        if (data.BrandName == null || data.BrandName == '') {
            $('#spnBrandName').text('BrandName is required');
            $("#spnBrandName").show();
            flag = false;

        }
        else {
            $('#spnBrandName').text('');
            $('#spnBrandName').hide();
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
        if (data.SubArea == null || data.SubArea == '') {
            $('#spnSubArea').text('SubArea is required');
            $("#spnSubArea").show();
            flag = false;
        }
        else {
            $('#spnSubArea').text('');
            $('#spnSubArea').hide();
        }
        if (data.SupplierName == null || data.SupplierName == '') {
            $('#spnSupplierName').text('SupplierName is required');
            $("#spnSupplierName").show();
            flag = false;
        }
        else {
            $('#spnSupplierName').text('');
            $('#spnSupplierName').hide();
        }

        if (flag == true) return data;
        else return null;
        //return data;
        //{
        //    else if return data
        //}
        //return null
    },

    Save: function () {
        var data = Assets.GetAssetData();

        var actionLink = '/Assets/SaveAssets';

        if (data.Id != null && data.Id != 0 && data.Id != '') {
            actionLink = '/Assets/UpdateAsset';
        }
        if (data != null) {
            $.ajax({
                type: 'POST',
                url: actionLink,
                data: Assets.GetAssetData(),
                success: function (data) {

                },
                complete: function () {
                    $('#AssetForm').modal('hide');
                    //Courses.GetCourseData();
                }
            });
        }
    },
   

    OpenDetailsModal: function (id) {
        $('#sub').hide();
        $('#myModalLabel').html('Details');
        $.ajax({
            type: 'GET',
            url: '/Assets/DetailsAsset?id=' + id,
            // data: obj,
            success: function (data) {
                $('#hdAssetID').val(data.id);
                $('#AssetName').val(data.name);
                $("input[name=SerializedAsset][value=" + data.isSerializedAsset + "]").attr('checked', true);
                $('#AssetTotalInhandQuantity').val(data.totalInhandQuantity);
                $('#txtIsSerializedAsset').val(data.IsSerializedAsset);
                $('#AssetSerialNo').val(data.serialNo);
                $('#AssetBarcode').val(data.assetBarcode);
                $('#AssetAcquiredDate').val(data.assetAcquiredDate);
                $('#AssetDescription').val(data.description);
                $('#AssetBrandName').val(data.brandName);
                $('#AssetLocation').val(data.location);
                $('#AssetSubArea').val(data.subArea);
                $('#AssetSupplierName').val(data.supplierName);
                $('#AssetCost').val(data.cost);
                $('#AssetColour').val(data.assetColour);
                $('#AssetHiddenFileUploadPath').val(data.assetPhoto);
                $('#photopath').hide();
                $('#preview').attr('src', 'https://' + location.host + '/img/' + data.assetPhoto);
                Assets.ToggleTextBox(true);
            },
            complete: function () {
                $('#AssetForm').modal('show');
            }
        });
    },
    ToggleTextBox: function (value) {
        $('#AssetName').prop('readonly', value);
        $('#txtIsSerializedAsset').prop('readonly', value);
        $('#AssetSerialNo').prop('readonly', value);
        $('#AssetBarcode').prop('readonly', value);
        $('#AssetAcquiredDate').prop('readonly', value);
        $('#AssetTotalInhandQuantity').prop('readonly', value);
        $('#AssetDescription').prop('readonly', value);
        $('#AssetBrandName').prop('readonly', value);
        $('#AssetLocation').prop('readonly', value);
        $('#AssetSupplierName').prop('readonly', value);
        $('#AssetSubArea').prop('readonly', value);
        $('#AssetCost').prop('readonly', value);
        $('#AssetColour').prop('readonly', value);
        $('#AssetHiddenFileUploadPath').prop('readonly', value);
    },
    Delete: function (id) {
        var Import = new Object();
        Import.id = id;
        bootbox.confirm({
            message: 'Are you sure want to delete',
            callback: function (data) {
                if (data) {
                    $.ajax({
                        type: 'Post',
                        url: '/Assets/DeleteAsset?id=' + id,
                        contentType: 'application/json',
                        success: function (data) {
                            $('#AssetForm').modal('hide');
                            alert('Deleted Successfully!');
                            //Courses.GetCourseData();
                        }
                    });
                }
            },
        });
    },

    OpenEditModal: function (id) {
        $('#myModalLabel').html('Edit');
        $('#sub').html('Edit');
        $('#sub').show();
        $.ajax({
            type: 'Get',
            url: '/Assets/GetAssetsData?id=' + id,
            success: function (data) {
                $('#hdAssetID').val(data.id);
                $('#AssetName').val(data.name);
                $("input[name=SerializedAsset][value=" + data.isSerializedAsset + "]").attr('checked', true);
                $('#txtIsSerializedAsset').val(data.isSerializedAsset);
                $('#AssetTotalInhandQuantity').val(data.totalInhandQuantity);
                $('#AssetSerialNo').val(data.serialNo);
                $('#AssetBarcode').val(data.assetBarcode);
                $('#AssetAcquiredDate').datepicker();
                $('#AssetAcquiredDate').datepicker('setDate', new Date(data.assetAcquiredDate));
                $('#AssetDescription').val(data.description);
                $('#AssetBrandName').val(data.brandName);
                $('#AssetLocation').val(data.location);
                $('#AssetSubArea').val(data.subArea);
                $('#AssetSupplierName').val(data.supplierName);
                $('#AssetCost').val(data.cost);
                $('#AssetColour').val(data.assetColour);
                $('#AssetHiddenFileUploadPath').val(data.assetPhoto);
                $('#txtAddedDate').val(data.addedDate);
                $('#txtModifiedDate').val(data.modifiedDate);
                $('#txtIPAddress').val(data.ipAddress);
                $('#txtFkCreatedBy').val(data.fkCreatedBy);
                $('#txtFkUpdatedBy').val(data.fkUpdatedBy);
                $('#preview').attr('src', location.protocol + "//" + location.host + '/img/' + data.assetPhoto);
                $('#photopath').show();
                $('#AssetForm').modal('show');
                Assets.ToggleTextBox(false);
            }
        });
    },
};