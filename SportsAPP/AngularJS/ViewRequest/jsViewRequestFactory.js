HomeApp.factory('ViewRequestFactory', ['$http', '$q', function ($http, $q) {


    var dataFactory = {};

    dataFactory.viewRequestOrderDetails = function (OrderId) {
        return $http.post('/ViewRequest/ViewRequestOrderDetails?OrderID=' + OrderId);
    };

    dataFactory.ChangedStatus = function (Data) {
      
        return $http.post('/ViewRequest/ChangedStatus', Data);
    };

    dataFactory.UploadFile = function (data) {
        
        /*
        var formData = new FormData();
        formData.append('file', file);
        formData.append('description', description);
        var defer = $q.defer()*/
        return  $http.post("/ViewRequest/SaveFiles/", data, {
            withCredentials: true,
            processData: false,
            headers: { 'Content-Type': undefined },
            transformRequest: angular.identity
        });
        //return $http.post('/ViewRequest/SaveFiles/', formData);
    }

    dataFactory.GetRequestedDocs = function (OrderId) {
        return $http.post('/ViewRequest/GetRequestedDocs?OrderID=' + OrderId);
    };

    //Bind Grant Code Details
    dataFactory.GrantCodeOrderDetails = function (OrderID) {

        return $http.post('/AddNewGrantCode/ViewRequestGrantCodeOrderDetails?OrderID=' + OrderID);
    };

    return dataFactory;
}]);


