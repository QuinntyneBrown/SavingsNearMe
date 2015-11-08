angular.module("app", ["ngX", "ngX.components"])
    .config([
        "$routeProvider", ($routeProvider: any) => {

            $routeProvider.when("/", {
                componentName: "homeComponent",
            });

            $routeProvider.when("/coupons", {
                componentName: "couponsComponent",
            });
    }
    ]);