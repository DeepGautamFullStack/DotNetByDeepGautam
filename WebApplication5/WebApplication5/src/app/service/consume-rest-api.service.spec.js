"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var consume_rest_api_service_1 = require("./consume-rest-api.service");
describe('ConsumeRestAPIService', function () {
    beforeEach(function () {
        testing_1.TestBed.configureTestingModule({
            providers: [consume_rest_api_service_1.ConsumeRestAPIService]
        });
    });
    it('should be created', testing_1.inject([consume_rest_api_service_1.ConsumeRestAPIService], function (service) {
        expect(service).toBeTruthy();
    }));
});
//# sourceMappingURL=consume-rest-api.service.spec.js.map