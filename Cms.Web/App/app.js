/// <reference path="E:/MyProject\Git\Cms.Shop\Cms.Web\Assets/Admin/Libs/angular/angular.js" />

(function () {
    angular.module('cmsShop', [
        'cmsShop.products',
        'cmsShop.productCategories',
        'cmsShop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider', '$locationProvider'];

    function config($stateProvider, $urlRouterProvider, $locationProvider) {
        $stateProvider.state('home', {
            url: '/admin',
            templateUrl: '/app/components/home/homeView.html',
            controller: 'homeController'
        });
        $urlRouterProvider.otherwise('/admin');

        //$locationProvider.html5Mode({
        //    enabled: true,

        //    requireBase: false
        //});
        $locationProvider.html5Mode(true);
    }

})();