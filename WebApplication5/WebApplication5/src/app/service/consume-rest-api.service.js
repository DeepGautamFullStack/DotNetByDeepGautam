"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var http_1 = require("@angular/http");
require("rxjs/add/operator/map");
var ConsumeRestAPIService = (function () {
    function ConsumeRestAPIService(http) {
        this.http = http;
        console.log("hello you are ready to consume restful service.");
    }
    //Below angular service is calling a webapi values controller.
    ConsumeRestAPIService.prototype.getValues = function () {
        return this.http.get("http://localhost:49328/api/values")
            .map(function (res) { return res.json(); });
    };
    //Below is the method to Get All Clients
    ConsumeRestAPIService.prototype.getAllClients = function () {
        return this.http.get("http://localhost:53251/api/Clients")
            .map(function (res) { return res.json(); });
    };
    //Below is the method to insert client
    ConsumeRestAPIService.prototype.postClient = function (model) {
        return this.http.post("http://localhost:53251/api/Clients", model)
            .map(function (res) { return res.json(); });
    };
    //Below is the method to update client
    ConsumeRestAPIService.prototype.putClient = function (id, model) {
        return this.http.put("http://localhost:53251/api/Clients?id=" + id, model)
            .map(function (res) { return res.json(); });
    };
    //Below is the method to delete client
    ConsumeRestAPIService.prototype.deleteClient = function (id) {
        return this.http.delete("http://localhost:53251/api/Clients?id=" + id)
            .map(function (res) { return res.json(); });
    };
    ConsumeRestAPIService.prototype.getPosts = function () {
        return this.http.get("https://jsonplaceholder.typicode.com/posts")
            .map(function (res) { return res.json(); });
    };
    return ConsumeRestAPIService;
}());
ConsumeRestAPIService = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], ConsumeRestAPIService);
exports.ConsumeRestAPIService = ConsumeRestAPIService;
//# sourceMappingURL=consume-rest-api.service.js.map