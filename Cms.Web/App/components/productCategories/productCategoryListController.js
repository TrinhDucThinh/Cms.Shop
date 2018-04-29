/// <reference path="E:/MyProject\Git\Cms.Shop\Cms.Web\Assets/Admin/Libs/angular/angular.js" />
(function (app) {
 
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService'];

    function productCategoryListController($scope, apiService) {
        $scope.productCategories = [];
        $scope.page = 0;
        $scope.pagesCount = 0;
        $scope.keyword = '';
        $scope.getProductCategories = getProductCategories;
        $scope.search = search;
        
        function search() {
            getProductCategories();
        }
       
        function getProductCategories(page) {
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 2
                }
            };

            apiService.get('/api/v1/product-category/get-all', config,
                function (result) {
                    $scope.productCategories = result.data.Items;
                    $scope.page = result.data.Page;
                    $scope.pagesCount = result.data.PagesCount;
                    $scope.totalCount = result.data.TotalCount;
                },
                function () {
                    console.log('Load productCategory failed');
                });
        }

        $scope.getProductCategories();
    }

})(angular.module('cmsShop.productCategories'))