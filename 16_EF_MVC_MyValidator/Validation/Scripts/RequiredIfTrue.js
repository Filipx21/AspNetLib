/// <reference path="jquery-3.4.1.js" />
/// <reference path="jquery.validate.js" />
/// <reference path="jquery.validate.unobtrusive.js" />


jQuery.validator.addMethod('requirediftrue', function (value, element, params) {
    var checkbox = $('#' + params).first();
    var checkboxValue = checkbox.is(":checked");
    return !checkboxValue || value;
}, '');

jQuery.validator.unobtrusive.adapters.addSingleVal("requirediftrue", "boolprop");


