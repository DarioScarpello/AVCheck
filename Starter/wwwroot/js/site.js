// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



//var items = document.getElementsByClassName("list-group-item active");


//var items = document.getelementsbyclassname("list-group-item");
//for (var i = 0; i < items.length; i++) {
//    if ((' ' + items[i].classname + ' ').indexof(' active ') > -1)
//        items[i].setattribute('style', 'color: #ffff00');
//    else
//        items[i].setattribute('style', 'color: #ccc');
//}


//tb.innerHTML = items.innerHTML;



function bruh() {
    if (select.value == "1") {
        label.value = "op 1";
    }
    else if (select.value == "2") {
        label.value = "op 2";
    }
    else if (select.value == "3") {
        label.value = "op 3";
    }
    else if (select.value == "4") {
        label.value = "op 4";
    }

};

var label = document.getElementById("exampleFormControlTextarea1");




$('.list-group-item').on('click', function () {
    var $this = $(this);
    var $alias = $this.data('alias');

    $('.active').removeClass('active');
    $this.toggleClass('active')

    // Pass clicked link element to another function
    myfunction($this, $alias)
})



function myfunction($this, $alias) {
    console.log($this.text());  // Will log Paris | France | etc...

    console.log($alias);  // Will output whatever is in data-alias=""

    document.getElementById("exampleFormControlTextarea1").value = $this.text();
}