
$(document).ready(function () {

    $("#loadButton").click(function () {

        //$.ajax(
        //    {
        //        url: "/service/contacts.aspx?all=1",
        //        type: "GET",
        //        dataType: "json",
        //        success: function (data) {
        //            //console.log(data);

        //            $("#myTableBody").empty();

        //            for (var i = 0; i < data.length; i++) {
        //                var ID = data[i].ID;
        //                var firstName = data[i].Firstname;
        //                var lastName = data[i].Lastname;
        //                var ssn = data[i].SSN;

        //                $("#myTableBody").append("<tr><td>" + ID + "</td><td>" + firstName + "</td><td>" + lastName + "</td><td>" + ssn + "</td></tr>");
        //            }
        //        }
        //    }
        //);

        $.getJSON("/service/contacts.aspx?all=1").
            done(function (data) {
                $("#myTableBody").empty();

                for (var i = 0; i < data.length; i++) {
                    $("#myTableBody").append("<tr><td>" + data[i].ID + "</td><td>" + data[i].Firstname + "</td><td>" + data[i].Lastname + "</td><td>" + data[i].SSN + "</td></tr>");
                }
            });
    });
});