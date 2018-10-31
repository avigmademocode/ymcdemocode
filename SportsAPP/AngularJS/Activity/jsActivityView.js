HomeApp.controller('ViewActivityController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {

    //kendo grid data

    function BindGrid(dataItem) {
        try {
            debugger
            var people = dataItem.Table
            $('#grid').kendoGrid({
                scrollable: true,
                sortable: true,


                pageable: {
                    pageSizes: true,
                    input: true,
                    pageSize: 5,
                    pageSizes: [5, 10, 20, 500]
                }
             
                , dataSource:
                    {
                        data: people,

                        schema: {
                            model: {
                                fields: {
                                    activity_name: { type: "string" },
                                    Branch_name: { type: "string" },
                                    city_name: { type: "string" },
                                    state_name: { type: "string" },
                                   
                                }
                            }
                        }
                    }
                , columns:
                    [
                        { field: "activity_name", title: "Activity", template: "<a href='/Activity/Activity?${Pkey_activity_id}'>${activity_name}</a>"}
                        , { field: "Branch_name", title: "Branch Name" }
                        , { field: "city_name", title: "City" }
                        , { field: "state_name", title: "State" }
                        
                    ]
            });
        }
        catch (e) {

        }

    }


    $scope.GetBranchData = function () {
        debugger;
        AjsFactory.getActivityDetailsData()
            .then(function (response) {

                if (response.data.length != 0) {
                    debugger;
                    dataItem = JSON.parse(response.data);
                    // var dataItem = { "Table": [{ "Pkey_Branch_id": 15, "Branch_name": "lower parel", "address1": "st. VG Road", "address2": "FA plaza", "address3": "werwe@dfs.com", "pincode": 432432, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T00:06:42.353", "modified_by": 0, "modified_on": "2018-09-21T00:06:42.353", "deleted_by": 0, "deleted_on": "2018-09-21T00:06:42.353", "is_delete": 0 }, { "Pkey_Branch_id": 18, "Branch_name": "Dadar", "address1": "CA Road", "address2": "Mumbai East", "address3": "gdfs.dsh@gmaill.com", "pincode": 435343, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T15:59:21.15", "modified_by": 0, "modified_on": "2018-09-21T15:59:21.15", "deleted_by": 0, "deleted_on": "2018-09-21T15:59:21.15", "is_delete": 0 }] };
                    //var dataItem = [{ "Pkey_Branch_id": 15, "Branch_name": "lower parel", "address1": "st. VG Road", "address2": "FA plaza", "address3": "werwe@dfs.com", "pincode": 432432, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T00:06:42.353", "modified_by": 0, "modified_on": "2018-09-21T00:06:42.353", "deleted_by": 0, "deleted_on": "2018-09-21T00:06:42.353", "is_delete": 0 }, { "Pkey_Branch_id": 15, "Branch_name": "lower parel", "address1": "st. VG Road", "address2": "FA plaza", "address3": "werwe@dfs.com", "pincode": 432432, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T00:06:42.353", "modified_by": 0, "modified_on": "2018-09-21T00:06:42.353", "deleted_by": 0, "deleted_on": "2018-09-21T00:06:42.353", "is_delete": 0 }, { "Pkey_Branch_id": 15, "Branch_name": "lower parel", "address1": "st. VG Road", "address2": "FA plaza", "address3": "werwe@dfs.com", "pincode": 432432, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T00:06:42.353", "modified_by": 0, "modified_on": "2018-09-21T00:06:42.353", "deleted_by": 0, "deleted_on": "2018-09-21T00:06:42.353", "is_delete": 0 }, { "Pkey_Branch_id": 15, "Branch_name": "lower parel", "address1": "st. VG Road", "address2": "FA plaza", "address3": "werwe@dfs.com", "pincode": 432432, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T00:06:42.353", "modified_by": 0, "modified_on": "2018-09-21T00:06:42.353", "deleted_by": 0, "deleted_on": "2018-09-21T00:06:42.353", "is_delete": 0 }, { "Pkey_Branch_id": 15, "Branch_name": "lower parel", "address1": "st. VG Road", "address2": "FA plaza", "address3": "werwe@dfs.com", "pincode": 432432, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T00:06:42.353", "modified_by": 0, "modified_on": "2018-09-21T00:06:42.353", "deleted_by": 0, "deleted_on": "2018-09-21T00:06:42.353", "is_delete": 0 }, { "Pkey_Branch_id": 15, "Branch_name": "lower parel", "address1": "st. VG Road", "address2": "FA plaza", "address3": "werwe@dfs.com", "pincode": 432432, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T00:06:42.353", "modified_by": 0, "modified_on": "2018-09-21T00:06:42.353", "deleted_by": 0, "deleted_on": "2018-09-21T00:06:42.353", "is_delete": 0 }, { "Pkey_Branch_id": 15, "Branch_name": "lower parel", "address1": "st. VG Road", "address2": "FA plaza", "address3": "werwe@dfs.com", "pincode": 432432, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T00:06:42.353", "modified_by": 0, "modified_on": "2018-09-21T00:06:42.353", "deleted_by": 0, "deleted_on": "2018-09-21T00:06:42.353", "is_delete": 0 }, { "Pkey_Branch_id": 15, "Branch_name": "lower parel", "address1": "st. VG Road", "address2": "FA plaza", "address3": "werwe@dfs.com", "pincode": 432432, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T00:06:42.353", "modified_by": 0, "modified_on": "2018-09-21T00:06:42.353", "deleted_by": 0, "deleted_on": "2018-09-21T00:06:42.353", "is_delete": 0 }, { "Pkey_Branch_id": 15, "Branch_name": "lower parel", "address1": "st. VG Road", "address2": "FA plaza", "address3": "werwe@dfs.com", "pincode": 432432, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T00:06:42.353", "modified_by": 0, "modified_on": "2018-09-21T00:06:42.353", "deleted_by": 0, "deleted_on": "2018-09-21T00:06:42.353", "is_delete": 0 }, { "Pkey_Branch_id": 15, "Branch_name": "lower parel", "address1": "st. VG Road", "address2": "FA plaza", "address3": "werwe@dfs.com", "pincode": 432432, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T00:06:42.353", "modified_by": 0, "modified_on": "2018-09-21T00:06:42.353", "deleted_by": 0, "deleted_on": "2018-09-21T00:06:42.353", "is_delete": 0 }, { "Pkey_Branch_id": 15, "Branch_name": "lower parel", "address1": "st. VG Road", "address2": "FA plaza", "address3": "werwe@dfs.com", "pincode": 432432, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T00:06:42.353", "modified_by": 0, "modified_on": "2018-09-21T00:06:42.353", "deleted_by": 0, "deleted_on": "2018-09-21T00:06:42.353", "is_delete": 0 }, { "Pkey_Branch_id": 15, "Branch_name": "lower parel", "address1": "st. VG Road", "address2": "FA plaza", "address3": "werwe@dfs.com", "pincode": 432432, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T00:06:42.353", "modified_by": 0, "modified_on": "2018-09-21T00:06:42.353", "deleted_by": 0, "deleted_on": "2018-09-21T00:06:42.353", "is_delete": 0 }, { "Pkey_Branch_id": 18, "Branch_name": "Hyd", "address1": "CA Road", "address2": "Mumbai East", "address3": "gdfs.dsh@gmaill.com", "pincode": 435343, "city": "Mumbai", "state": "Maharastra", "country": null, "created_by": 0, "created_on": "2018-09-21T15:59:21.15", "modified_by": 0, "modified_on": "2018-09-21T15:59:21.15", "deleted_by": 0, "deleted_on": "2018-09-21T15:59:21.15", "is_delete": 0 }];

                    try {

                        BindGrid(dataItem);

                    }
                    catch (e) {
                        alert(e);
                    }


                } else {
                    alert('Record Not Found!');
                }

            });

    }



    function isNumeric(n) {
        return !isNaN(parseFloat(n)) && isFinite(n);
    }

    $('#filter').on('input', function (e) {

        var grid = $('#grid').data('kendoGrid');
        var columns = grid.columns;

        var filter = { logic: 'or', filters: [] };
        columns.forEach(function (x) {
            if (x.field) {
                var type = grid.dataSource.options.schema.model.fields[x.field].type;
                if (type == 'string') {
                    filter.filters.push({
                        field: x.field,
                        operator: 'contains',
                        value: e.target.value
                    })
                }
                else if (type == 'number') {
                    if (isNumeric(e.target.value)) {
                        filter.filters.push({
                            field: x.field,
                            operator: 'eq',
                            value: e.target.value
                        });
                    }

                } else if (type == 'date') {
                    var data = grid.dataSource.data();
                    for (var i = 0; i < data.length; i++) {
                        var dateStr = kendo.format(x.format, data[i][x.field]);

                        if (dateStr.startsWith(e.target.value)) {
                            filter.filters.push({
                                field: x.field,
                                operator: 'eq',
                                value: data[i][x.field]
                            })
                        }
                    }
                } else if (type == 'boolean' && getBoolean(e.target.value) !== null) {
                    var bool = getBoolean(e.target.value);
                    filter.filters.push({
                        field: x.field,
                        operator: 'eq',
                        value: bool
                    });
                }
            }
        });
        grid.dataSource.filter(filter);
    });
    $scope.GetBranchData();


}]);