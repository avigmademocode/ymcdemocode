HomeApp.controller('ViewRequestController', ['$scope', '$window', '$location', 'ViewRequestFactory', function ($scope, $window, $location, ViewRequestFactory) {

    $scope.OrderID = $scope.OrderID ? $scope.OrderID.split('?')[1] : window.location.search.slice(9);

    $scope.ViewRequestOrderDetails = function () {

        ViewRequestFactory.viewRequestOrderDetails($scope.OrderID)
            .then(function (response) {

                if (response.data[0].length != 0) {
                    $scope.RequestDetails = response.data[0];
                }
                if (response.data[1].length != 0) {
                    $scope.ApprovarDetails = response.data[1];
                }
                if (response.data[2].length != 0) {
                    $scope.CartItems = response.data[2];
                }
                if (response.data[3].length != 0) {
                    $scope.SAdd1 = response.data[3][0];
                    $scope.SAdd2 = response.data[3][1];
                    $scope.SAdd3 = response.data[3][2];
                    $scope.SCity = response.data[3][3];
                    $scope.SState = response.data[3][4];
                    $scope.SZip = response.data[3][5];
                    $scope.SCountry = response.data[3][6];
                }
                if (response.data[4].length != 0) {
                    $scope.BAdd1 = response.data[4][0];
                    $scope.BAdd2 = response.data[4][1];
                    $scope.BAdd3 = response.data[4][2];
                    $scope.BCity = response.data[4][3];
                    $scope.BState = response.data[4][4];
                    $scope.BZip = response.data[4][5];
                    $scope.BCountry = response.data[4][6];
                }
                if (response.data[5].length != 0) {
                    $scope.Prodcount = response.data[5][0].ProdCount;
                }
                if (response.data[6].length != 0) {
                    $scope.Status = response.data[6];
                }
                if (response.data[7] != null) {
                    if (response.data[7].length != 0) {
                        $scope.OrderLog = response.data[7];
                    }
                }

                if (response.data[8].length != 0) {

                    $scope.Buttonlist = response.data[8];
                }

            });
    }
    $scope.ViewRequestOrderDetails();


    $scope.AddFreight = function () {
        $window.location.href = '/AddFreightQuote?' + $scope.OrderID;
    }

    $scope.OnImageChange = function (picFile) {
        //   debuggerBu
        $scope.ImgFile = picFile;
    }

    //$scope.formData = [];
    $scope.saveDocuments = function () {
        //  debugger
        ViewRequestFactory.saveDocuments(picFile)
            .then(function (response) {

            })
    }

    $scope.Print = function () {
        $window.print();
    }

    $scope.EditCustomer = function () {
        debugger;
        $window.location.href = '/NewRequest?' + $scope.OrderID;

    }

    $scope.SaveStatusChange = function () {

        // debugger;
        var Data = {
            OrderID: $scope.OrderID,
            Type: 1,
            ChangedStatus: $scope.ChangedStatus,  // For Cancel Pass StatusID = 0
            Reason: $scope.Reason,
            LeadTime: null,
            FullStatus: null
        }
        ViewRequestFactory.ChangedStatus(Data)
           .then(function (response) {

           })
        $scope.ViewRequestOrderDetails();
        //$window.location.reload();
    }


    $scope.CancelStatusChange = function () {

        //  debugger;
        var Data = {
            OrderID: $scope.OrderID,
            Type: 2,
            ChangedStatus: 0,  // For Cancel Pass StatusID = 0
            Reason: $scope.Reason, // Resason Value for that Pop up
            LeadTime: null,
            FullStatus: null
        }
        ViewRequestFactory.ChangedStatus(Data)
            .then(function (response) {

            })
        $scope.ViewRequestOrderDetails();
        // $window.location.reload();
    }

    $scope.LastStatusChange = function () {

        // debugger;
        var Data = {
            OrderID: $scope.OrderID,
            Type: 3,
            ChangedStatus: -1,  // For Cancel Last StatusID = -1
            Reason: $scope.Reason, // Resason Value for that Pop up
            LeadTime: 0,
            FullStatus: null

        }
        ViewRequestFactory.ChangedStatus(Data)
            .then(function (response) {

            })
        $scope.ViewRequestOrderDetails();
        //  $window.location.reload();
    }


    $scope.FreightChange = function () {

        // debugger;
        var Data = {
            OrderID: $scope.OrderID,
            Type: 4,
            ChangedStatus: null,  // For Cancel Last StatusID = -1
            Reason: $scope.LeadReason, // Resason Value for that Pop up
            //LeadTime: $scope.LeadTime, // Pass the textbox value 
            FullStatus: null
        }
        ViewRequestFactory.ChangedStatus(Data)
            .then(function (response) {

            })
        $scope.ViewRequestOrderDetails();
        //   $window.location.reload();
    }



    //New Upload File Code

    //Variables
    $scope.Message = "";
    $scope.FileInvalidMessage = "";
    $scope.SelectedFileForUpload = "";
    $scope.FileDescription = "";
    $scope.IsFormSubmitted = "";
    $scope.IsFileValid = "";
    $scope.IsFormValid = "";

    $scope.files = [];

    //File Select Event
    $scope.SelectFileforUpload = function (file) {

        //for single file
        $scope.SelectedFileForUpload = file[0];

        //for multiple files
        // STORE THE FILE OBJECT IN AN ARRAY.
        for (var i = 0; i < file.length; i++) {
            $scope.files.push(file[i])
        }


    }

    //Save File
    $scope.SaveFile = function () {

        $scope.FileDescription = 'Hello Testing...'
        //FILL FormData WITH FILE DETAILS.
        var data = new FormData();


        for (var i = 0; i < $scope.files.length; i++) {
            data.append("files[" + i + "]", $scope.files[i])
            data.append("description[" + i + "]", $scope.OrderID);
        }
        ViewRequestFactory.UploadFile(data)
            .then(function (response) {
                $scope.UploadedFiles = response.data[0];
                alert('File uploaded successfully...');
                // $window.location.reload();
                $scope.uploadfiles = [];
                $scope.Add();
            });
    }





    //Dynamic File Upload
    $scope.uploadfiles = [];

    $scope.Add = function () {
        //Add the new item to the Array.
        var fileObj = {};
        fileObj.ImageUpload = $scope.ImageUpload;
        $scope.uploadfiles.push(fileObj);

        //Clear the TextBoxes.
        $scope.ImageUpload = "";
    };
    $scope.Add();

    $scope.Remove = function (index) {
        //Find the record using Index from Array.
        var name = $scope.uploadfiles[index].ImageUpload;
        if ($window.confirm("Do you want to delete: " + name)) {
            //Remove the item from Array using Index.
            $scope.uploadfiles.splice(index, 1);
        }
    }

    function download() {
        var iframe = document.getElementById('invisible');
        iframe.src = "~/image/product/laptop.jpg";
    }

    $scope.getRequestedDocs = function () {

        ViewRequestFactory.GetRequestedDocs($scope.OrderID)
            .then(function (response) {
                console.log(response.data[0])
                $scope.UploadedFiles = response.data[0];
            });
    }
    $scope.getRequestedDocs();


    //Bind Grand Code Data

    $scope.GrantCodeOrderDetails = function () {
        ViewRequestFactory.GrantCodeOrderDetails($scope.OrderID)
            .then(function (response) {
                if (response.data[0].length > 0) {
                    //$scope.CalcTotalAmt(response.data[1]);
                    debugger
                    $scope.Seriallst = response.data[1];
                    $scope.grantcodeOrderdatalst = response.data[0];
                    $scope.OriginalTotalOrderAmount = response.data[2][0].TotalOrderAmount
                }
            });
    }
    $scope.GrantCodeOrderDetails();

    $scope.GoToEditGrantCode = function () {
        debugger
        $window.localStorage.setItem("IsEdit", "True");
        $window.location.href = '/AddNewGrantCode/AddMultipleGrantCode?' + $scope.OrderID;
    }

    $scope.CalcTotalAmt = function (AmtData) {
        var TotalAmt = 0;
        for (var i = 0; i < AmtData.length; i++) {
            TotalAmt = 0
            for (var j = 0; j < AmtData[i].Data.length; j++) {
                if (AmtData[i].Data[j].SelectedItem != undefined && AmtData[i].Data[j].SelectedItem != null && AmtData[i].Data[j].SelectedItem != "") {
                    TotalAmt += AmtData[i].Data[j].SelectedItem.split('\,')[1] * AmtData[i].Data[j].SelQty;
                }
                else {
                    TotalAmt += 0;
                }
            }
            $scope.Seriallst[i].TotalAmt = TotalAmt;
        }
    }


}]);