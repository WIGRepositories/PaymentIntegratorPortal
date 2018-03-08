// JavaScript source code
var myapp1 = angular.module('myApp', ['ngStorage', 'ui.bootstrap'])
var mycrtl1 = myapp1.controller('myCtrl', function ($scope, $http, $localStorage) {
    //if ($localStorage.uname == null) {
    //    window.location.href = "login.html";
    //}
    $localStorage.uname = "Admin";
    $scope.uname = $localStorage.uname;
    $scope.userdetails = $localStorage.userdetails;
    //$scope.Roleid = $scope.userdetails.roleid;
   
    $scope.getTypes = function () {
        $http.get('/api/Types/TypesByGroupId?groupid=1').then(function (res, data) {

            {
                $scope.TypeGroups = res.data;

            }
        });
        $http.get('/api/Types/TypesByGroupId?groupid=2').then(function (dat, data) {
            {
                $scope.TypeGroups1 = dat.data;
            }
        });


    }

    $scope.ValidateFOCode = function (FleetOwnerCode) {

        if (FleetOwnerCode == null) {

            alert('Please Enter valid Reference code or Contact Administrator.');
            return false;
        }
        else {

            $http.get('/api/Licenses/getReferenceId?ReferenceId=' + FleetOwnerCode).then(function (response, req) {
                 $scope.foLicenseDetails = response.data;
                window.location.href = "Payments.html"
                
            });
            
            //
        }
        


    };
        
    $scope.showDialog = function (message) {

        var modalInstance = $uibModal.open({
            animation: $scope.animationsEnabled,
            templateUrl: 'myModalContent.html',
            controller: 'ModalInstanceCtrl',
            resolve: {
                mssg: function () {
                    return message;
                }
            }
        });
    }




    $scope.setCompany = function (grp) {
        $scope.currGroup = grp;
    };

    $scope.clearGroup = function () {
        $scope.currGroup = null;

    };
    $scope.showDialog = function (message) {

        var modalInstance = $uibModal.open({
            animation: $scope.animationsEnabled,
            templateUrl: 'myModalContent.html',
            controller: 'ModalInstanceCtrl',
            resolve: {
                mssg: function () {
                    return message;
                }
            }
        });
    }

});

myapp1.controller('ModalInstanceCtrl', function ($scope, $uibModalInstance, mssg) {

    $scope.mssg = mssg;
    $scope.ok = function () {
        $uibModalInstance.close('test');
    };

    $scope.cancel = function () {
        $uibModalInstance.dismiss('cancel');
    };

    $scope.showDialog = function (message) {

        var modalInstance = $uibModal.open({
            animation: $scope.animationsEnabled,
            templateUrl: 'myModalContent.html',
            controller: 'ModalInstanceCtrl',
            resolve: {
                mssg: function () {
                    return message;
                }
            }
        });
    }
});