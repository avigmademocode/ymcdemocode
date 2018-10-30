HomeApp.factory('AjsFactory', ['$http', '$q', function ($http, $q) {


    var dataFactory = {};

    dataFactory.AddNewBranch = function (data) {
      //debugger;
        return $http.post('/Branch/AddNewBrach', data);
    };

    dataFactory.AddMember = function (data) {
       //debugger;
        return $http.post('/Member/AddMemberData', data);
    };
    //get member data
    //dataFactory.getMemberDetailsData = function ()
    //{
    //    debugger;
    //    return $http.post('/Member/GetMemberDatas');
            
    //};
    dataFactory.AddReceiptData = function (data) {
      //  debugger;
        return $http.post('/ActivityReceipt/AddReceiptData',data);
    }

    //add activity
    dataFactory.AddActivityDetail = function (data) {
        debugger;
        return $http.post('/Activity/AddActivityData', data);
    };

    //add renewal membership data
    dataFactory.AddActivitydata = function (data) {
        //debugger;
        return $http.post('/MembershipRenewal/AddMembershipRenewalDataDetail', data);
    };

    //datafactory.getMemberReceiptData = function (data) {
    //    debugger;
    //    return $http.post('/Member/GetMemberReceiptData',data);
    //}




    //get branch data
    dataFactory.getBranchDetailsData = function () {
        //debugger;
        return $http.post('/Branch/GetBranch');

    };

    //get member data
    dataFactory.getMemberDetailsData = function () {
        return $http.post('/Member/GetMemberData');

    };
    //get Activity data
    dataFactory.getActivityDetailsData = function () {
        return $http.post('/Activity/GetActivity');

    };


    //get branch city data
    dataFactory.getCityData = function () {
        debugger;
        return $http.post('/Branch/GetBranchCityData');
    };
    //get branch state data
    dataFactory.getStateData = function () {
        debugger;
        return $http.post('/Branch/GetBarchStateData');
    };


    // get activity citydata
    dataFactory.getCityDetailsdata = function () {
      //  debugger;
        return $http.post('/activity/getactivitycitydata');
    };
    //get activity state data
    dataFactory.getStateDetailsdata = function () {
        //debugger;
        return $http.post('/activity/getactivitystatedata');
    };


    //getmember branch data
    dataFactory.getBranchData = function () {
        //debugger;
        return $http.post('/Member/GetMemberBranchData');
    };


    //add special interests data
    dataFactory.addSpecialInterestsData = function (data) {
        debugger;
        return $http.post('/Member/AddSpecialInterestsDetailData', data);
    };

    dataFactory.addProQulificationData = function (data) {
        debugger;
        return $http.post('/Member/AddProQulificationDetailData', data);
    };

    dataFactory.addGSTPerData = function (data) {
        debugger;
        return $http.post('/Member/AddGSTPerData', data);
    };

    //add duplicate card data
    dataFactory.AddDuplicateCard = function (data) {
        debugger;
        
        return $http.post('/DuplicateMembershipCard/AddDuplicateMembershipData',data);
    };

    return dataFactory;
}]);


    