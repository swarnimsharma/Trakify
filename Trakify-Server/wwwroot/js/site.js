// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var SiteSystem = {
    LoadDropDown: function (type, bind_control, filter_id, selected_id, ids, selected_ids) {
        $("#" + bind_control).empty();
        $("#" + bind_control).append($("<option></option>").val(0).html("Loading.."));
        var BindData = { type: type, id: filter_id, ids: ids };
        $.ajax({
            type: "GET",
            url: "/DropDown/GetDropdown",
            contentType: "application/json",
            data: BindData,
            dataType: "json",
            asnc: false,
            success: function (response) {
                debugger;
                $("#" + bind_control).empty();
                $.each(response, function (i, item) {
                    $("#" + bind_control).append($("<option></option>").val(item.value).html(item.name));
                });

                if (selected_id == null || selected_id == undefined || selected_id == "undefined") {
                    //
                }
                else {
                    $("#" + bind_control).val(selected_id);
                }
            },
            error: function (Result) {
                setTimeout(function () {
                    $("#" + bind_control).empty();
                    $("#" + bind_control).append($("<option></option>").val(0).html("Problem in data.."));
                }, 2000);

              
            }
        });
    }
}