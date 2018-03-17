var app = angular.module('myApp', ['ngStorage'])

var ctrl = app.controller('myCtrl', function ($scope, $http, $localStorage) {


    $scope.selectedOp = 0;

    if ($localStorage.uname) {
        $scope.username = $localStorage.uname;
    }

    if ($localStorage.uname) {
        $scope.UserName = $localStorage.uname;

        $scope.MobileNumber = $localStorage.userdetails[0].MobileNumber;
       

        $http.get('/api/Registration/GetRegistrations?logininfo=' + $scope.MobileNumber).then(function (response, data) {
            $scope.userdetails = response.data[0];

        });
        $scope.emailid = $localStorage.userdetails[0].EmailId;
       
    } 

    $scope.Signin = function () {

        var u = $scope.UserName;
        var p = $scope.Password

        if (u == null) {
            alert('Please enter username');
            return;
        }

        if (p == null) {
            alert('Please enter password');
            return;
        }
        var inputcred = { LoginInfo: u, Passkey: p }

        var req = {
            method: 'POST',
            url: '/api/ValidateCredentials/ValidateCredentials',
            data: inputcred
        }

        $http(req).then(function (res) {

            if (res.data.length == 0) {
                alert('invalid credentials');
            }else {
                //if the user has role, then get the details and save in session
                $localStorage.uname = res.data[0].FirstName;
                $scope.username = $localStorage.uname;
                $localStorage.userdetails = res.data;
                //  window.location.href = "UI/BookedTicketHistory.html";
                //$uibModal.close();
                if ($scope.selectedOp == 1) {
                    window.location.href = "BookedTicketHistory.html";
                }
            
                else {
                    window.location.href = "UserProfile.html";
                }
                //switch ($scope.SelectedOp) {
                //    case 1:
                //        window.location.href = "UI/BookedTicketHistory.html";
                //        break;                    
                //    case 2:
                //        window.location.href = "UI/CancelTicket.html";
                //        break;
                //    case 3:
                //        window.location.href = "UI/Feedback.html";
                //        break;
                //    case 4:
                //        window.location.href = "UserProfile.html";
                //        break;
                //    default:
                //        window.location.href = "UserProfile.html";
                //        break;
                //        break;
                //}

            }
        });
    }

    $scope.LogoutUser = function () {
        $localStorage.uname = null;
        $scope.UserName = null;
        $localStorage.userdetails = null;

        window.location.href = "../index.html";
    }
});