/**
 * @name CouponDataService
 */

class CouponDataService {

    constructor(private apiEndpoint:any, private dataService: any) { }

    public getAll = () => {
        return this.dataService.fromServiceOrCache({ method: "GET", url: this.baseUri + "/getAll" });
    }

    public getById = (options: any) => {
        return this.dataService.fromServiceOrCache({ method: "GET", url: this.baseUri + "/getById", params: options.params });
    }

    public add = (options: any) => {
        return this.dataService.fromServiceOrCache({ method: "POST", url: this.baseUri + "/add", data: options.data});
    }

    public get baseUri() { return this.apiEndpoint.getBaseUrl() + "/coupon"; }

}

angular.module("app").service("couponDataService", ["apiEndpoint","dataService",CouponDataService]);