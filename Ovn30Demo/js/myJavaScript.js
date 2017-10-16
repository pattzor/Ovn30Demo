$(document).ready(function () {
    $("#loadContacts").click(function () {
        $.ajax({
            url: "/svc/_contacts.aspx?all=1",
            type: "get",
            dataType: "json",
            success: function (data) {

                $("#myTableBody").empty();

                for (var i = 0; i < data.length; i++) {
                    var contact = data[i];

                    $("#myTableBody").append("<tr><td>" + contact.ID + "</td><td>" + contact.Firstname + "</td><td>" + contact.Lastname + "</td><td>" + contact.SSN + "</td></tr>");
                }
            }
        });
    });
});