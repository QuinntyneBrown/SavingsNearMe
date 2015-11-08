angular.module("app", ["ngX", "ngX.components"])
    .config([
    "$routeProvider", function ($routeProvider) {
        $routeProvider.when("/", {
            componentName: "homeComponent",
        });
        $routeProvider.when("/coupons", {
            componentName: "couponsComponent",
        });
    }
]);
//# sourceMappingURL=app.module.js.map