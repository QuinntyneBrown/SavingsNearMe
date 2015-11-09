/**
 * @name CouponDataService
 */

class CouponDataService {

    constructor(private apiEndpointConfig:any, private dataService: any) { }

    public getAll = () => {
        return this.dataService.fromServiceOrCache({ method: "GET", url: this.baseUri + "/getAll" });
    }

    public getById = (options: any) => {
        return this.dataService.fromServiceOrCache({ method: "GET", url: this.baseUri + "/getById", params: options.params });
    }

    public add = (options: any) => {
        return this.dataService.fromServiceOrCache({ method: "POST", url: this.baseUri + "/add", data: options.data});
    }

    public get baseUri() { return this.apiEndpointConfig.getBaseUrl() + "/coupon"; }

}

angular.module("app").service("couponDataService", ["dataService",CouponDataService]);