HomeApp.factory('AjsFactory', ['$http', '$q', function ($http, $q) {


    var dataFactory = {};

    dataFactory.AddNewBranch = function (data) {
      //debugger;
        return $http.post('/Branch/AddNewBrach', data);
    };

    dataFactory.AddMember = function (data) {
       debugger;
        return $http.post('/Member/AddMemberData', data);
    };

    //get member data for edit
    dataFactory.GetMemberData = function (data){
        debugger;
        return $http.post('/Member/GetMemberDatas',data);
            
    };
    dataFactory.AddReceiptData = function (data) {
       // debugger;
        return $http.post('/ActivityReceipt/AddReceiptData',data);
    }

    //add activity
    dataFactory.AddActivityDetail = function (data) {
       // debugger;
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
<<<<<<< HEAD
       // debugger;
=======
        //debugger;
>>>>>>> 9858edd3bc038be83f5a55553c9526ef0455afe9
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
        //debugger;
        return $http.post('/Branch/GetBranchCityData');
    };
    //get branch state data
    dataFactory.getStateData = function () {
        //debugger;
        return $http.post('/Branch/GetBarchStateData');
    };


    // get activity citydata
    dataFactory.getCityDetailsdata = function () {
        //debugger;
        return $http.post('/activity/getactivitycitydata');
    };
    //get activity state data
    dataFactory.getStateDetailsdata = function () {
        //debugger;
        return $http.post('/activity/getactivitystatedata');
    };


    //getmember branch data
    dataFactory.getBranchData = function () {
<<<<<<< HEAD
       // debugger;
=======
        //debugger;
>>>>>>> 9858edd3bc038be83f5a55553c9526ef0455afe9
        return $http.post('/Member/GetMemberBranchData');
    };


    //add special interests data
    dataFactory.addSpecialInterestsData = function (data) {
        //debugger;
        return $http.post('/Member/AddSpecialInterestsDetailData', data);
    };


    dataFactory.addProQulificationData = function (data) {
        //debugger;
        return $http.post('/Member/AddProQulificationDetailData', data);
    };

    dataFactory.addGSTPerData = function (data) {
       // debugger;
        return $http.post('/Member/AddGSTPerData', data);
    };

    //add duplicate card data
    dataFactory.AddDuplicateCard = function (data) {
       // debugger;
        
        return $http.post('/DuplicateMembershipCard/AddDuplicateMembershipData',data);
    };
    
    //get member name dynamically
    dataFactory.getMemeberIDData = function () {
        //debugger;
        return $http.post('/MembershipRenewal/GetMemberDataById');
    };

    //get special interest Data
    dataFactory.getSpecialInterestData = function (data) {
        //debugger;
        return $http.post('/Member/GetSpecialInterestData', data);
    };

    dataFactory.GetProQulificationData = function (Data) {
        //debugger;
        return $http.post('/Member/GetProQulificationDetailData', Data);
    };

    dataFactory.GetGSTPercentageData = function (Data) {
        //debugger;
        return $http.post('/Member/GetGSTPercentageDetailsData',Data);
    };

    //Add member fee Data
    dataFactory.AddMemberFeeDetailsData = function (Data) {
        //debugger;
        return $http.post('/Member/AddMemberFeeDetail',Data);
    };

    //get member fee data
    dataFactory.GetMemberfeeData = function () {
        //debugger;
        return $http.post('/Member/GetMemberFeeDetailData');
    };

    //add user data
    dataFactory.AddUserData = function (data) {
      //  debugger;
        return $http.post('/User/AddUserDetailData',data);
    }

    //get user data
    dataFactory.getUserData = function (data) {
       // debugger;
        return $http.post('/User/GetUserDetailData',data);
    }

    // get Activity Data for Edit
    dataFactory.getActivityDetailsdata = function (data) {
        //debugger;
        return $http.post('/Activity/GetActivitydetailData',data);

    };

    dataFactory.GetspecialinterestData = function () {
        //debugger;
        return $http.post('/Member/GetSpecialInterestData');
    };
    dataFactory.GetProfessionData = function () {
        //debugger;
        return $http.post('/Member/GetProQulificationDetailData');
    };

   

    return dataFactory;
}]);


    