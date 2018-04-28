/// <reference path="E:/MyProject\Git\Cms.Shop\Cms.Web\Assets/Admin/Libs/angular/angular.js" />
(function (app) {
 
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService'];

    function productCategoryListController($scope, apiService) {
        $scope.productCategories = [];

        $scope.getProductCategories = getProductCategories;
       
        function getProductCategories() {

            apiService.get('/api/v1/product-category/get-all',null,
                function (result) {
                    $scope.productCategories = result.data;
                },
                function () {
                    console.log('Load productCategory failed');
                });
        }

        $scope.getProductCategories();
    }

})(angular.module('cmsShop.productCategories'))