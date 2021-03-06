﻿'use strict';

goog.provide('PianoForte.Controllers.Widgets.SearchBoxController');

PianoForte.Controllers.Widgets.SearchBoxController = function ($scope, $attrs, $element) {
    $scope.initialize = function () {
        adjustWidth();
        adjustSearchIconPosition();
    };

    $scope.search = function () {
        // To do
    };

    function adjustWidth () {
        if ($scope.width !== undefined) {
            $element.css('width', $scope.width + 'px');
        }
    };

    function adjustSearchIconPosition () {
        var inputElement = $element[0].children[0].children[0];
        if (inputElement !== undefined) {
            var searchButtonElement = $element[0].children[0].children[1];
            if (searchButtonElement !== undefined) {
                searchButtonElement.style.top = ((inputElement.clientHeight - searchButtonElement.clientHeight) / 2) + 'px';
            }  

            var searchIconElement = $element[0].children[0].children[2];
            if (searchIconElement !== undefined) {
                searchIconElement.style.top = ((inputElement.clientHeight - searchIconElement.clientHeight) / 2) + 'px';    
            }
        }
    };
};