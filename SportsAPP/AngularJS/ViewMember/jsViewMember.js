HomeApp.controller('ViewMemberController', ['$scope', '$window', '$location', 'AjsFactory', function ($scope, $window, $location, AjsFactory) {

    //kendo grid data


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
                                    first_name: { type: "string" },
                                    last_name: { type: "string" },
                                    mobile_number: { type: "number" },
                                    email_id: { type: "string" },
                                    PermAddress1: { type: "string" },
                                    Perm_pincode: { type: "number" },
                                    city: { type: "string" },
                                    state: { type: "string" },

                                }
                            }
                        }
                    }
                , columns:
                    [
                        { field: "first_name", title: "First Name", template: "<a href=''>${first_name}</a>" }
                        , { field: "last_name", title: "Last Name" }
                        , { field: "mobile_number", title: "Mobile Number" }
                        , { field: "email_id", title: "Email" }
                        , { field: "PermAddress1", title: "Address" }
                        , { field: "Perm_pincode", title: "Zip" }
                        , { field: "city", title: "City" }
                        , { field: "state", title: "State" }
                    ]


            });
        }
        catch (e) {

        }

    }


    $scope.GetMemberData = function () {
        //debugger;
        AjsFactory.getMemberDetailsData()
            .then(function (response) {

                if (response.data.length != 0) {
                    //debugger;
                    dataItem = JSON.parse(response.data);
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
    $scope.GetMemberData();



}]);