
var app = angular.module('myApp', ['ngStorage', 'ui.bootstrap'])

var ctrl = app.controller('myCtrl', function ($scope, $http, $localStorage) {

    $scope.selectedOp = 0;

    if ($localStorage.uname) {
        $scope.username = $localStorage.uname;
    }
  
    //$scope.carouselImages = [{ "ID": 1, "Name": "TRAVEL WITH INTERBUS", "Caption": "Every Journey Matters....", "Path": "UI/Images/promos/11.jpg" }
    //    , { "ID": 2, "Name": "Customer satisfaction", "Caption": "The comfort and convienience of travelling with INTERBUS", "Path": "/UI/Images/promos/12.png" }
    //    , { "ID": 3, "Name": "Online Ticket Booking", "Caption": "Automated ticketing increases performance and convienience", "Path": "/UI/Images/promos/13.jpg" }
    //    , { "ID": 4, "Name": "Hassel free travel", "Caption": "Get online tickets to make the journey hassel free", "Path": "/UI/Images/promos/14.png" }
    //    , { "ID": 5, "Name": "Extensive coverage", "Caption": "Wide network taking you to various destinations", "Path": "/UI/Images/promos/2.png" }
    //];
    //$scope.triptype = "oneway";

    //$scope.timing = "Now";

    //$scope.ChangeTravelType = function (travelTime) {
    //    $scope.timing = (travelTime == 0) ? "Now" : "Later";
    //}
 
   

    var INTERVAL = 1000;
    //  slides = (
    //$scope.GetCarousel = function () {
    //    $http.get('/api/Carousel/GetCarousel').then(function (res, data) {
    //           $scope.slides = res.data;

    //       // slides = [


    //       //{ id: "image00", src: "http://localhost:3121/ui/images/img4.jpg", title: 'Our love', subtitle: 'will prove everyone wrong!' },
    //       //{ id: "image01", src: "http://localhost:3121/ui/images/img4.jpg", title: 'Can you feel', subtitle: 'the love tonight!' },
    //       //{ id: "image02", src: "http://localhost:3121/ui/images/img4.jpg", title: 'You are the wind', subtitle: 'beneath my wings' }
    //       // ];

    //   });

    //    loadSlides();


    //    }

    //{ id: "image00", src: "./images/image00.jpg", title: 'Our love', subtitle: 'will prove everyone wrong!' },
    //{ id: "image01", src: "./images/image01.jpg", title: 'Can you feel', subtitle: 'the love tonight!' },
    //{ id: "image02", src: "./images/image02.jpg", title: 'You are the wind', subtitle: 'beneath my wings' },
    //{ id: "image03", src: "./images/image03.jpg", title: 'Anything for you', subtitle: 'even accepting your family' },
    //{ id: "image04", src: "./images/image04.jpg", title: 'True love', subtitle: 'a dream within a dream' }
    //   );

  
   
    $scope.GetCountry = function () {

        $http.get('/api/Country/GetCountry?active=1').then(function (response, req) {
            $scope.Countries = response.data;

        });
    }
    $scope.GetStops = function () {

        $http.get('/api/Stops/GetStops').then(function (response, req) {
            $scope.Stops = response.data;
            $localStorage.Stops = $scope.Stops;
        }, function (data) {

        });

        $http.get('/api/Stops/TypesByGroupId?groupid=3').then(function (res, data) {
            $scope.licenses = res.data;

        });
    }
    $scope.GetAdvertisment = function () {

        $http.get('/api/Advertisement/GetAdvertisment').then(function (response, req) {
            $scope.advertisement = response.data;
        });
    }
    $scope.GetActivityLog = function () {

        $http.get('/api/Advertisement/GetActivityLog').then(function (response, req) {
            $scope.activityimages = response.data;
        });
    }
  

 
   
    $scope.Signin = function () {

        var u = $scope.UserName;
        var p = $scope.Password

        if (u == null) {
            $scope.showDialog('Please enter username');
            return;
        }

        if (p == null) {
            $scope.showDialog('Please enter password');
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
            }
            else {
                //if the user has role, then get the details and save in session
                $localStorage.uname = res.data[0].Name;
                $scope.username = $localStorage.uname;
                $localStorage.userdetails = res.data;
                //  window.location.href = "UI/BookedTicketHistory.html";
                //$uibModal.close();
                if ($scope.selectedOp == 1) {
                    window.location.href = "BookedTicketHistory.html";
                }

                else {
                    window.location.href = "UI/UserProfile.html";
                }

            }
        });
    }

    $scope.SignOutUser = function () {
        $localStorage.uname = null;
        $scope.username = null;
        $localStorage.userdetails = null;
    }

    //$scope.GotToLicensePage = function (t) {
    //    $localStorage.licenseId = t;
    //    window.location.href = "UI/LicensePage.html";
    //}


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
                //$localStorage.NewFOcode = data[0].FleetOwnerCode;
                //$localStorage.FOemailid = FleetOwnerRequest1.EmailAddress;
                //$scope.showDialog('saved successfully. The fleet owner code is ' + data[0].FleetOwnerCode + '.\n please use the code to buy license.\n The same has been sent to the given e-mailid:' + FleetOwnerRequest1.EmailAddress+'.',0);


                //window.location.href = "FOConfirmation.html";
            }).error(function (ata, status, headers, config) {
                $scope.showDialog(ata.ExceptionMessage, 1);
            });

        $scope.clearFleetOwnerRequest1 = function () {
            $scope.FleetOwnerRequest1 = null;
        };
    }

    $scope.RecentJourneyClick = function () {
        if ($localStorage.uname) {
            window.location.href = "UI/BookedTicketHistory.html";
        }
        else {
            $scope.selectedOp = 1;
        }

    }


    $scope.showDialog = function (message) {
        //alert(message);
        //var modalInstance = $uibModal.open({
        //    animation: $scope.animationsEnabled,
        //    templateUrl: 'statusPopup.html',
        //    controller: 'ModalInstanceCtrl',
        //    resolve: {
        //        mssg: function () {
        //            return message;
        //        }
        //    }
        //});
    }

});

app.controller('ModalInstanceCtrl', function ($scope, $uibModalInstance, mssg) {

    $scope.mssg = mssg;
    $scope.ok = function () {
        $uibModalInstance.close('test');
    };

    $scope.cancel = function () {
        $uibModalInstance.dismiss('cancel');
    };
});







