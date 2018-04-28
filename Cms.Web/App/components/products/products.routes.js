/// <reference path="\Assets/Admin/Libs/angular/angular.js" />
(function () {

    angular.module('cmsShop.products', ['cmsShop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('product-list',{
                url: '/product-list',
                templateUrl: '/App/components/products/productListView.html',
                controller: 'productListController'
            })
            .state('product-add', {
                url: '/product-add',
                templateUrl: '/App/components/products/productAddView.html',
                controller: 'productAddController'
            })
        $urlRouterProvider.otherwise('/admin');
    }

})();