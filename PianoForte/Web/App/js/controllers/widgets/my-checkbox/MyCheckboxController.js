﻿'use strict';

goog.provide('PianoForte.Controllers.Widgets.MyCheckboxController');

PianoForte.Controllers.Widgets.MyCheckboxController = function ($scope, $attrs, $element) {
    $scope.initialize = function () {    
        adjustCheckedIconPosition();
    };

    $scope.toggleCheck = function () {
    	$scope.checked = !$scope.checked;

        $scope.onChanged({ 
            e: {
                checked: $scope.checked,
                name: $scope.name
            }
        });
    };

    function adjustCheckedIconPosition () {
        var checkedIconElement = $element[0].children[0].children[0];
        var textElement = $element[0].children[0].children[1];
        
        if ((textElement !== undefined) && (checkedIconElement !== undefined)) {
            checkedIconElement.style.lineHeight = textElement.clientHeight + 'px';        
        }
    };
};