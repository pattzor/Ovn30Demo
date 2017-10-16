
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

        LoadAllContacts();
    });


});

function DeleteContact(cid) {
    $.get("/service/contacts.aspx?deleteCID=" + cid).
        done(function (data) {

            if (data.trim() == "ok")
            {
                LoadAllContacts();
            }
            else
                alert("Darn...");
        });
}

function LoadAllContacts()
{
    $.getJSON("/service/contacts.aspx?all=1").
        done(function (data) {
            $("#myTableBody").empty();

            for (var i = 0; i < data.length; i++) {

                var tableRow = "<tr><td>" + data[i].ID + "</td>";
                tableRow += "<td>" + data[i].Firstname + "</td>";
                tableRow += "<td>" + data[i].Lastname + "</td>";
                tableRow += "<td>" + data[i].SSN + "</td>";
                tableRow += "<td><input type=\"button\" value=\"Delete contact\" onclick=\"DeleteContact(" + data[i].ID + ");\" /></td>";
                tableRow += "</tr>";

                $("#myTableBody").append(tableRow);
            }
        });
}