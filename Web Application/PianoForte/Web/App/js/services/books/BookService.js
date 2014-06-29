﻿'use strict';

goog.provide('PianoForte.Services.BookService');

PianoForte.Services.BookService = function($http) {
    var databaseName = 'pianoforte_b01';
    
    return {
        getBookList: function(onSuccess, onError) {
            var data = {
                databaseName: databaseName
            };

            $http.post('/WebServices/BookWebService.asmx/getBookList', data).success(onSuccess).error(onError);
        },

        getBookInfoById: function(bookId, onSuccess, onError) {
        	var data = {
                databaseName: databaseName,
                bookId: bookId
            };

            $http.post('/WebServices/BookWebService.asmx/getBookById', data).success(onSuccess).error(onError);
        },

        getBookInfoByBarcode: function(bookBarcode, onSuccess, onError) {
        	var data = {
                databaseName: databaseName,
                bookBarcode: bookBarcode
            };

            $http.post('/WebServices/BookWebService.asmx/getBookByBarcode', data).success(onSuccess).error(onError);
        },

        updateBookInfo: function (book, onSuccess, onError) {
            var data = {
                databaseName: databaseName,
                book: {
                    Id: book.id.value,
                    Barcode: book.barcode.value,
                    Name: book.name.value,
                    UnitPrice: book.unitPrice.value,
                    Quantity: book.quantity.value,
                    Status: book.status.value
                }
            };

            $http.post('/WebServices/BookWebService.asmx/updateBookInfo', data).success(onSuccess).error(onError);
        },
    }
};