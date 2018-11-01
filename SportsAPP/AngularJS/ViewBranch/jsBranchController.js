HomeApp.controller('ViewBranchController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {

    //kendo grid data

    function BindGrid(dataItem) {
        try {
            //debugger
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
                // selectable: "row",//""multiple row"",
                // filterable: true
                ///ViewRequest?{{ord.OrderId}}
                , dataSource:
                    {
                        data: people,

                        schema: {
                            model: {
                                fields: {
                                    Branch_name: { type: "string" },
                                    address1: { type: "string" },
                                    BranchEmailId: { type: "string" },
                                    pincode: { type: "string" },
                                    city_name: { type: "string" },
                                    state_name: { type: "string" },

                                }
                            }
                        }
                    }
                , columns:
                    [
                        { field: "Branch_name", title: "Branch Name", template: "<a href='/Branch/Add/Index?${Pkey_Branch_id}'>${Branch_name}</a>"}
                        , { field: "address1", title: "Address" }
                        , { field: "BranchEmailId", title: "Branch Email ID" }
                        , { field: "pincode", title: "Pincode" }
                        , { field: "city_name", title: "City Name" }
                        , { field: "state_name", title: "State Name" }
                    ]


            });
        }
        catch (e) {

        }

    }


    $scope.GetBranchData = function () {
        //debugger;
        AjsFactory.getBranchDetailsData()
            .then(function (response) {

                if (response.data.length != 0) {
                    //debugger;
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