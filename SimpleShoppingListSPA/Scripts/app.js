var currentList = {};
function createShoppingList() {
    currentList.name = $("#shoppingListName").val();
    currentList.items = new Array();
    //web service call
    showShoppingList();
    
}
function addItem() {
    var newItem = {};
    newItem.name = $("#newItemName").val();
    currentList.items.push(newItem);
     
    console.info(currentList);
    drawItems();
    $("#newItemName").val("");
}
function drawItems() {
    var $list = $("#shoppingListItems").empty();
    for (var i = 0; i < currentList.items.length; i++) {
        var currentItem = currentList.items[i];
        var $li = $("<li>").html(currentItem.name).attr("id", "item_" + i);
        var $deleteBtn = $("<button onclick='deleteItem("+ i +")'>D</button>").appendTo($li);
        var checkBtn = $("<button onclick='checkItem("+ i +")'>C</button>").appendTo($li);
        $li.appendTo($list);
    }

}
function deleteItem(index) {
    currentList.items.splice(index, 1);
    drawItems();
}
function checkItem(index) {
    if ($("#item_" + index).hasClass("checked")) {
        $("#item_" + index).removeClass("checked");

    }
    else {
        $("#item_" + index).addClass("checked");
    }
}
function showShoppingList() {
    $("#shoppingListTitle").html(currentList.name);
    $("#shoppingListItems").empty();
    $("#createListDiv").hide();
    $("#shoppingListDiv").show();
    
    $("#newItemName").focus();
    $("#newItemName").keyup(function (event) {
        if (event.keyCode == 13) {
            addItem();
        }
    });
};
function getShoppingListById(id) {
    console.info(id);
    currentList.name = "Mock shopping list";
    currentList.items = [
        { name: "Milk" },
        {name:"cornflakes"},
        {name:"Strawberries"}

    ];
    showShoppingList();
    drawItems();
}
$(document).ready(function () {
    var pageUrl = window.location.href;
    $("#shoppingListName").focus();
    $("#shoppingListName").keyup(function (event) {
        if (event.keyCode == 13) {
            createShoppingList();
        }
    });
    var idIndex = pageUrl.indexOf("?id=");
    if (idIndex != -1) {
        if (idIndex != -1) {
            getShoppingListById(pageUrl.substring(idIndex + 4));
        }
    }
 });