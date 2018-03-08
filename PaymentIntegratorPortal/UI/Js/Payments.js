var app = angular.module('myApp', ['ngStorage', 'ui.bootstrap'])
var ctrl = app.controller('myCtrl', function ($scope, $http, $localStorage) {

    $scope.selectedOp = 0;
    if ($localStorage.uname) {
        $scope.username = $localStorage.uname;
    }

   
    $scope.saveNew = function (Register, flag) {

        //if (adv.CompanyName == null) {
        //    alert('Please Enter CompanyName');
        //    return;
        //}
        //if ($scope.imageSrc == null) {
        //    alert('Please Enter Image');
        //    return;
        //}
        //if (adv.Title == null) {
        //    alert('Please Enter Title');
        //    return;
        //}

        //if (adv.Description == null) {
        //    alert('Please Enter Description');
        //    return;
        //}
        //if (adv.AdvertismentDate == null) {
        //    alert('Please Enter AdvertismentDate');
        //    return;
        //}
        ////if (adv.AdvertismentExpiredDate == null) {
        ////    alert('Please Enter AdvertismentExpiredDate');
        ////    return;
        ////}
        //if (adv.AdvertismentAmount == null) {
        //    alert('Please Enter AdvertismentAmount');
        //    return;
        //}
        //if (adv.Area == null) {
        //    alert('Please Enter Area');
        //    return;
        //}


        var Advertisment = {
            Id: -1,
            BankName: Register.BankName,
            UserName: Register.UserName,
            Password: Register.Password,
            CardHolderName: Register.CardHolderName,
            CardNumber: Register.CardNumber,
            ExpMonth: Register.ExpMonth,
            ExpYear: Register.ExpYear,
            CCode: Register.CCode,
            flag: 'I',
        }

        var req = {
            method: 'POST',
            url: '/api/Payments/MakePayment',
            data: Advertisment
        }
        $http(req).then(function (response) {

            alert("Saved successfully!");

            $scope.Group = null;

        }, function (errres) {
            var errdata = errres.data;
            var errmssg = "your Details Are Incorrect";
            errmssg = (errdata && errdata.ExceptionMessage) ? errdata.ExceptionMessage : errdata.Message;
            alert(errmssg);
        });
        $scope.currGroup = null;
    };
   
});