// JavaScript source code
var app = angular.module('myApp', ['ngStorage', 'ui.bootstrap'])
var ctrl = app.controller('myCtrl', function ($scope, $http, $uibModal, $localStorage) {
    $scope.selectedOp = 0;
    if ($localStorage.uname) {
        $scope.username = $localStorage.uname;
    }

  

  
    $scope.save = function (Register, flag) {
        if (Register == null) {
            alert('Please enter Details.');
            return;
        }
        if (Register.Name == null) {
            alert('Please enter Name.');
            return;
        }
        if (Register.Email == null) {
            alert('Please enter Email.');
            return;
        }
        if (Register.Company == null) {
            alert('Please enter Company.');
            return;
        }
        if (Register.Country == null) {
            alert('Please enter Country.');
            return;
        }
        var fleetOwnerRequest = {
            //user details            
            Name: Register.Name,
            Email: Register.Email,
            Company: Register.Company,
            Country: Register.Country,
            Address: Register.Address,
            MobileNumber: Register.Mobile,
            Password: Register.Password,  
           flag: 'I',


        }
        var req = {
            url: '/api/Registration/RegistrationDetails',
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            data: fleetOwnerRequest
        }

        $http(req)
            .success(function (data, status, headers, config) {
                //if (data[0]['status'] == "0") {
                //    alert(data[0]['details']);
                //    return;
                //}
                alert("Registered Succesfully. We will contact You soon!")
                $localStorage.NewFOcode = data[0].FleetOwnerCode;
                $localStorage.FOemailid = FleetOwnerRequest1.EmailAddress;
                //$scope.showDialog('saved successfully. The fleet owner code is ' + data[0].FleetOwnerCode + '.\n please use the code to buy license.\n The same has been sent to the given e-mailid:' + FleetOwnerRequest1.EmailAddress+'.',0);
                

                window.location.href = "FOConfirmation.html";
            }).error(function (ata, status, headers, config) {
                $scope.showDialog(ata.ExceptionMessage, 1);
            });

        $scope.clearFleetOwnerRequest1 = function () {
            $scope.FleetOwnerRequest1 = null;
        };
    }
});

app.controller('ModalInstanceCtrl', function ($scope, $uibModalInstance, mssg, status) {

    $scope.mssg = mssg;
    $scope.status = status;
    $scope.ok = function () {
        $uibModalInstance.close('test');
    };

    $scope.cancel = function () {
        $uibModalInstance.dismiss('cancel');
    };

});











