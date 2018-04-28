/// <reference path="\Assets/Admin/Libs/angular/angular.js" />
(function () {

	angular.module('cmsShop.productCategories', ['cmsShop.common']).config(config);

	config.$inject = ['$stateProvider', '$urlRouterProvider'];

	function config($stateProvider, $urlRouterProvider) {
		$stateProvider
            .state('product-category-list', {
                url: '/product-category-list',
            	templateUrl: '/App/components/productCategories/productCategoryListView.html',
                controller: 'productCategoryListController'
            })
            .state('product-category-add', {
            	url: '/product-category-add',
            	templateUrl: '/App/components/productCategories/productCategoryAddView.html',
                controller: 'productCategoryAddController'
            })
		$urlRouterProvider.otherwise('/admin');
	}

})();