/// <reference path="../typings/jquery/jquery.d.ts" />
/// <reference path="../typings/jqueryui/jqueryui.d.ts" />

window.onload = function () {
    validationCheckbox();
    deleteMenu();

    $('#button').click(function () {

        var validation = checkValidation();
        if (validation) {
            animateRotate(360, 1000);
            setTimeout(function () {
                var arr1 = $("#workDay li");
                var lengthOptions = $("#workDay li").length;
                var lengthVegetable = $("#accompVegetable p").length;
                var i: number = 0;
                var vgt: number = 0;
                do {
                        Math.floor(Math.random() * lengthOptions)
                        var $randomList = $("#workDay li").eq(Math.floor(Math.random() * lengthOptions));
                        var $randomVeg = $("#accompVegetable p").eq(Math.floor(Math.random() * lengthVegetable));
                        
                        $("#result td").eq(i).text($randomList.text() + " with " + $randomVeg.text());
                        i++;
                        vgt++;
                    } while (i < 5);
                },
                1100); 
            setTimeout(function () {
                    $("#result td").eq(5)
                        .text($('#lunch input:checked').eq(0).val() + " and " + $('#dinner input:checked').eq(0).val());
                    $("#result td").eq(6)
                        .text($('#lunch input:checked').eq(1).val() + " and " + $('#dinner input:checked').eq(1).val());
                },
                1100);
        } else
            return false;
    })
};

function animateRotate(angle: number, duration: number) {

    var $elem = $('#button');

    $({ deg: 0 }).animate({ deg: angle }, {
        duration: duration,
        step: function (now) {

            $elem.css({
                transform: 'rotate(' + now + 'deg)'
            });
        }
    });
}

function validationCheckbox() {
    $('#lunch input, #dinner input').on('change', function (evt) {
        if ($("#lunch input:checked").length > 2) {
            this.checked = false;
            $('#alertLunch').dialog();
        }
        if ($("#dinner input:checked").length > 2) {
            this.checked = false;
            $('#alertDinner').dialog();
        }
    });
};



function checkValidation() {
    if ($('#lunch input:checked, #dinner input:checked').length != 4) {
        $('#alertQuantity').dialog();
        return false;
    } else
        return true;
}

function deleteMenu() {
    $('#newChoise').click(function () {
        $("#result td").empty();
        $('#lunch input, #dinner input').prop('checked', false);
    });
};