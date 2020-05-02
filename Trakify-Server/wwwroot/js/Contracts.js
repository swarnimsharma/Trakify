//$(function () {
//    $.ajax({
//        type: 'GET',
//        url: '/Contracts/_Contracts',
//        contentType: 'application/json',
//        success: function (data) {
//            $('#divContracts').html(data);
//        },
//        complete: function () {
//            //$('#tblAssets').DataTableDataTable();
//        }
//    });
//});

var Contracts = {

    Reset: function () {
        $('#hdContractID').val('');
        $('#ContractName').val('');
        $('#ContractContactNo').val('');
        $('#ContractContactSubTypeCode').val('');
        $('#ContractPrice').val('');
        $('#ContractBillingSchedule').val('');
        $('#ContractStartDate').val('');
        $('#ContractEndDate').val('');
        $('#ContractIncludeNoService').val('');
        $('#ContractPurchaseOrder').val('');
        $('#ContractServicesDescription').val('');
        $('#ContractPrivateNotes').val('');
        $('#ContractContactPersonName').val('');
        $('#ContractContactPersonPhone').val('');
        $('#ContractContactPersonMobile').val('');
        $('#ContractFkContractType').val('');
        $('#ContractAddressCountry').val('');
        $('#ContractContactPersonEmail').val('');
        $('#sub').show();
        $('#spnName').text('');
        $('#spnName').hide();
        $('#spnCity').text('');
        $('#spnCity').hide();
        $('#spnContactNo').text('');
        $('#spnContactNo').hide();
        $('#spnPrice').text('');
        $('#spnPrice').hide();
        $('#spnStartDate').text('');
        $('#spnStartDate').hide();
        $('#spnEndDate').text('');
        $('#spnEndDate').hide();
        $('#spnIncludeNoService').text('');
        $('#spnIncludeNoService').hide();
        $('#spnPurchaseOrder').text('');
        $('#spnPurchaseOrder').hide();
        $('#spontactpersonemail').text('');
        $('#spontactpersonemail').hide();
        $('#spnPrivateNotes').text('');
        $('#spnPrivateNotes').hide();
        $('#spnContactPersonName').text('');
        $('#spnContactPersonName').hide();
        $('#spnContactPersonPhone').text('');
        $('#spnContactPersonPhone').hide();
        $('#spnContactPersonMobile').text('');
        $('#spnContactPersonMobile').hide();
        $('#spnAddressCountry').text('');
        $('#spnAddressCountry').hide();
        $('#spnServicesDescription').text('');
        $('#spnServicesDescription').hide();
        $('#spnBillingSchedule').text('');
        $('#spnBillingSchedule').hide();
        $('#spnSubTypeCode').text('');
        $('#spnSubTypeCode').hide();
        

        $('#sub').html('Create');
        Contracts.ToggleTextBox(false);
    },
    OpenPopUp: function () {
        Contracts.Reset();
        Contracts.GetContractType();
        $('#ContractForm').modal('show');
    },
    GetContractType: function () {
        $.ajax({
            type: "GET",
            url: "/Contracts/GetContractType",
            contentType: "application/json",
            success: function (response) {
                $('#ddContractType').empty().append('<option selected="selected" value="0">Contract Type</option>');
                for (var i = 0; i < response.length; i++) {
                    $('#ddContractType').append($("<option></option>").val(response[i].id).html(response[i].type));
                }
            }
        });
    },
    GetContractData: function () {
        var flag = true;
        var data =
        {
            Id: $('#hdContractID').val(),
            Name: $('#ContractName').val(),
            //IsSerializedAsset: IsSerializedAsset,
            ContactNo: $('#ContractContactNo').val(),
            ContactSubTypeCode: $('#ContractContactSubTypeCode').val(),
            Price: $('#ContractPrice').val(),
            BillingSchedule: $('#ContractBillingSchedule').val(),
            StartDate: $('#ContractStartDate').val(),
            ContractEndDate: $('#ContractEndDate').val(),
            IncludeNoService: $('#ContractIncludeNoService').val(),
            PurchaseOrder: $('#ContractPurchaseOrder').val(),
            ServicesDescription: $('#ContractServicesDescription').val(),
            PrivateNotes: $('#ContractPrivateNotes').val(),
            ContactPersonName: $('#ContractContactPersonName').val(),
            ContactPersonPhone: $('#ContractContactPersonPhone').val(),
            ContactPersonMobile: $('#ContractContactPersonMobile').val(),
            FkContractType: $('#ddContractType').val(),
            AddressCountry: $('#ContractAddressCountry').val(),
            ContactPersonEmail: $('#contractcontactpersonemail').val()
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

        if (data.ContactNo == null || data.ContactNo == '') {
            $('#spnContactNo').text('contact is required');
            $("#spnContactNo").show();
            flag = false;
        }
        else {
            $('#spnContactNo').text('');
            $('#spnContactNo').hide();
        }
        if (data.ContactSubTypeCode == null || data.ContactSubTypeCode == '') {
            $('#spnSubTypeCode').text('subcode is required');
            $("#spnSubTypeCode").show();
            flag = false;
        }
        else {
            $('#spnSubTypeCode').text('');
            $('#spnSubTypeCode').hide();
        }
        if (data.Price == null || data.Price == '') {
            $('#spnPrice').text('Price is required');
            $("#spnPrice").show();
            flag = false;
        }
        else {
            $('#spnPrice').text('');
            $('#spnPrice').hide();
        }
        if (data.BillingSchedule == null || data.BillingSchedule == '') {
            $('#spnBillingSchedule').text('BillingSchedule is required');
            $("#spnBillingSchedule").show();

        }
        else {
            $('#spnBillingSchedule').text('');
            $('#spnBillingSchedule').hide();
        }
        if (data.StartDate == null || data.StartDate == '') {
            $('#spnStartDate').text('StartDate is required');
            $("#spnStartDate").show();
            flag = false;

        }
        else {
            $('#spnStartDate').text('');
            $('#spnStartDate').hide();
        }
        if (data.ContractEndDate == null || data.ContractEndDate == '') {
            $('#spnEndDate').text('ContractEndDate is required');
            $("#spnEndDate").show();
            flag = false;

        }
        else {
            $('#spnEndDate').text('');
            $('#spnEndDate').hide();
        }
        if (data.IncludeNoService == null || data.IncludeNoService == '') {
            $('#spnIncludeNoService').text('IncludeNoService is required');
            $("#spnIncludeNoService").show();
            flag = false;

        }
        else {
            $('#spnIncludeNoService').text('');
            $('#spnIncludeNoService').hide();
        }
        if (data.PurchaseOrder == null || data.PurchaseOrder == '') {
            $('#spnPurchaseOrder').text('PurchaseOrder is required');
            $("#spnPurchaseOrder").show();
            flag = false;
        }
        else {
            $('#spnPurchaseOrder').text('');
            $('#spnPurchaseOrder').hide();
        }
        if (data.ServicesDescription == null || data.ServicesDescription == '') {
            $('#spnServicesDescription').text('ServicesDescription is required');
            $("#spnServicesDescription").show();
            flag = false;
        }
        else {
            $('#spnServicesDescription').text('');
            $('#spnServicesDescription').hide();
        }
        if (data.PrivateNotes == null || data.PrivateNotes == '') {
            $('#spnPrivateNotes').text('PrivateNotes is required');
            $("#spnPrivateNotes").show();
            flag = false;
        }
        else {
            $('#spnPrivateNotes').text('');
            $('#spnPrivateNotes').hide();
        }
        if (data.ContactPersonName == null || data.ContactPersonName == '') {
            $('#spnContactPersonName').text('ContactPersonName is required');
            $("#spnContactPersonName").show();
            flag = false;
        }
        else {
            $('#spnContactPersonName').text('');
            $('#spnContactPersonName').hide();
        }
        if (data.ContactPersonPhone == null || data.ContactPersonPhone == '') {
            $('#spnContactPersonPhone').text('ContactPersonPhone is required');
            $("#spnContactPersonPhone").show();
            flag = false;
        }
        else {
            $('#spnContactPersonPhone').text('');
            $('#spnContactPersonPhone').hide();
        }
        if (data.ContactPersonMobile == null || data.ContactPersonMobile == '') {
            $('#spnContactPersonMobile').text('ContactPersonMobile is required');
            $("#spnContactPersonMobile").show();
            flag = false;
        }
        else {
            $('#spnContactPersonMobile').text('');
            $('#spnContactPersonMobile').hide();
        }

        if (data.AddressCountry == null || data.AddressCountry == '') {
            $('#spnAddressCountry').text('AddressCountry is required');
            $("#spnAddressCountry").show();
            flag = false;
        }
        else {
            $('#spnAddressCountry').text('');
            $('#spnAddressCountry').hide();
        }
        if (data.ContactPersonEmail == null || data.ContactPersonEmail == '') {
            $('#spnContactPersonEmail').text('ContactPersonEmail is required');
            $("#spnContactPersonEmail").show();
            flag = false;
        }
        else {
            $('#spnContactPersonEmail').text('');
            $('#spnContactPersonEmail').hide();
        }

        if (flag == false) {
            return null;
        }
        else return data;

    },

    SaveContract: function () {
        var data = Contracts.GetContractData();
        var actionLink = '/Contracts/SaveContract';

        if (data.Id != null && data.Id != 0 && data.Id != '') {
            actionLink = '/Contracts/UpdateContract';
        }
        if (data != null) {
            debugger;
            $.ajax({
                type: 'POST',
                url: actionLink,
                data: Contracts.GetContractData(),
                success: function (data) {
                },
                complete: function () {
                    $('#ContractForm').modal('hide');
                    bootbox.alert('Contract Saved');
                }
            });
        }
    },

    OpenDetailsModal: function (id) {
        $('#sub').hide();
        $('#myModalLabel').html('Details');
        $.ajax({
            type: 'GET',
            url: '/Contracts/DetailsContract?id=' + id,
            // data: obj,
            success: function (data) {
                $('#hdContractID').val(data.id);
                $('#ContractName').val(data.name);
                $('#ContractContactNo').val(data.contactNo),
                    $('#ContractContactSubTypeCode').val(data.contactSubTypeCode),
                    $('#ContractPrice').val(data.price),
                    $('#ContractBillingSchedule').val(data.billingSchedule),
                    $('#ContractStartDate').val(data.startDate),
                    $('#ContractEndDate').val(data.endDate),
                    $('#ContractIncludeNoService').val(data.includeNoService),
                    $('#ContractPurchaseOrder').val(data.purchaseOrder),
                    $('#ContractServicesDescription').val(data.servicesDescription),
                    $('#ContractPrivateNotes').val(data.privateNotes),
                    $('#ContractContactPersonName').val(data.contactPersonName),
                    $('#ContractContactPersonPhone').val(data.contactPersonPhone),
                    $('#ContractContactPersonMobile').val(data.contactPersonMobile),
                    $('#ContractFkContractType').val(data.fkContractType),
                    $('#ContractAddressCountry').val(data.addressCountry),
                    $('#ContractContactPersonEmail').val(data.contactPersonEmail);
                Contracts.ToggleTextBox(true);

            },
            complete: function () {
                $('#ContractForm').modal('show');
            }
        });
    },
    ToggleTextBox: function (value) {
        $('#ContractName').prop('readonly', value);
        $('#ContractContactNo').prop('readonly', value);
        $('#ContractContactSubTypeCode').prop('readonly', value);
        $('#ContractPrice').prop('readonly', value);
        $('#ContractBillingSchedule').prop('readonly', value);
        $('#ContractStartDate').prop('readonly', value);
        $('#ContractEndDate').prop('readonly', value);
        $('#ContractIncludeNoService').prop('readonly', value);
        $('#ContractPurchaseOrder').prop('readonly', value);
        $('#ContractServicesDescription').prop('readonly', value);
        $('#ContractPrivateNotes').prop('readonly', value);
        $('#ContractContactPersonName').prop('readonly', value);
        $('#ContractContactPersonPhone').prop('readonly', value);
        $('#ContractContactPersonMobile').prop('readonly', value);
        $('#ContractFkContractType').prop('readonly', value);
        $('#ContractAddressCountry').prop('readonly', value);
        $('#ContractContactPersonEmail').prop('readonly', value);


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
                        url: '/Contracts/DeleteContract?id=' + id,
                        contentType: 'application/json',
                        success: function (data) {
                            $('#DeleteModal').modal('hide');
                            alert('Deleted Successfully!');
                        },
                        complete: function (data) {
                            $.ajax({
                                url: '/Contracts/Index',
                                method: 'GET',
                                success: function (data) { },
                                error: function () {
                                    alert('Some error occurred');
                                },
                            });
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
            url: '/Contracts/GetContractData?id=' + id,
            success: function (data) {
                $('#hdContractID').val(data.id);
                $('#ContractName').val(data.name);
                $('#ContractContactNo').val(data.contactNo),
                    $('#ContractContactSubTypeCode').val(data.contactSubTypeCode),
                    $('#ContractPrice').val(data.price),
                    $('#ContractBillingSchedule').val(data.billingSchedule),
                    $('#ContractStartDate').val(data.startDate),
                    $('#ContractEndDate').val(data.endDate),
                    $('#ContractIncludeNoService').val(data.includeNoService),
                    $('#ContractPurchaseOrder').val(data.purchaseOrder),
                    $('#ContractServicesDescription').val(data.servicesDescription),
                    $('#ContractPrivateNotes').val(data.privateNotes),
                    $('#ContractContactPersonName').val(data.contactPersonName),
                    $('#ContractContactPersonPhone').val(data.contactPersonPhone),
                    $('#ContractContactPersonMobile').val(data.contactPersonMobile),
                    $('#ContractFkContractType').val(data.fkContractType),
                    $('#ContractAddressCountry').val(data.addressCountry),
                    $('#ContractContactPersonEmail').val(data.contactPersonEmail);
                //$('#photopath').show();
                $('#ContractForm').modal('show');
                Assets.ToggleTextBox(false);
            }
        });
    },
};