/**
 * /table data filtering function
 * @param {any} number of table column
 */
function filterData(number) {
    var input, filter, table, tr, td, i;
    
    input = document.getElementById("filterInput_" + number);
    filter = input.value.toUpperCase();
    table = document.getElementById("playerTable");
    tr = table.getElementsByTagName("tr");
    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[number];
        if (td) {
            if (td.innerHTML.toUpperCase().startsWith(filter)) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }
}

/*
 * /table data sorting function 
 * @param {any} number of table column
 */
function sortTable(number) {
    let table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
    table = document.getElementById("playerTable");
    switching = true;

    dir = "asc";
    while (switching) {

        switching = false;
        rows = table.getElementsByTagName("tr");

        for (i = 1; i < (rows.length - 1); i++) {
            shouldSwitch = false;
            debugger;
            x = rows[i].getElementsByTagName("td")[number].innerHTML;
            y = rows[i + 1].getElementsByTagName("td")[number].innerHTML;
            
            if (+x) { x = +x; y = +y } else { x = x.toLowerCase(); y = y.toLowerCase(); }
            
            if (dir == "asc") {
                if (x > y) {
                    shouldSwitch = true;
                    break;
                }
            } else if (dir == "desc") {
                if (x < y) {
                    shouldSwitch = true;
                    break;
                }
            }
        }
        if (shouldSwitch) {
            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
            switching = true;
            switchcount++;
        } else {
            if (switchcount == 0 && dir == "asc") {
                dir = "desc";
                switching = true;
            }
        }
    }
}
