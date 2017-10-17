$(document).ready(function () {

    $("#loadButton").click(function () {
        LoadAllContacts();
    });
});

function LoadAllContacts() {
    $.getJSON("/service/contacts.aspx?all=1").
        done(function (data) {
            $(".myDivTableBody").empty();

            for (var i = 0; i < data.length; i++) {

                var tableRow = "";
                tableRow += "<div id=\"myDivRow" + data[i].ID + "\" class=\"myDivTableRow\" style=\"display: none;\">";
                tableRow += " <div class=\"myDivTableCell\">" + data[i].ID + "</div>";
                tableRow += " <div class=\"myDivTableCell\">" + data[i].Firstname + "</div>";
                tableRow += " <div class=\"myDivTableCell\">" + data[i].Lastname + "</div>";
                tableRow += " <div class=\"myDivTableCell\">" + data[i].SSN + "</div>";
                tableRow += " <div class=\"myDivTableCell\"><input type=\"button\" value=\"Delete contact\" onclick=\"DeleteContact(" + data[i].ID + ");\" /></div>";
                tableRow += "</div>";

                $(".myDivTableBody").append(tableRow);

                $("#myDivRow" + data[i].ID).fadeIn(900);
            }
        });
}

function DeleteContact(cid) {
    $.get("/service/contacts.aspx?deleteCID=" + cid).
        done(function (data) {

            if (data.trim() == "ok") {

                // Not calling LoadAllContacts here. This will save a postback.
                $("#myDivRow" + cid).fadeOut();
                $("#myDivRow" + cid).remove();
                $(".myDivTableRow:even").css("background-color", "#D0E4F5");
                $(".myDivTableRow:odd").css("background-color", " #EEEEEE");
            }
            else
                alert("Darn...");
        });
}