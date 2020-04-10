import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { InventoryProductSummaryDto } from 'autogen/InventoryProductSummaryDto';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BackendService {

  constructor(
    private _http: HttpClient, @Inject('BASE_URL') private baseUrl: string
  ) { }


  getInventorySummary(): Observable<InventoryProductSummaryDto[]> {
    return this._http.get<InventoryProductSummaryDto[]>(this.baseUrl + 'api/inventory');
  }

  getProductList(): Observable<InventoryProductSummaryDto[]> {
    return this._http.get<InventoryProductSummaryDto[]>(this.baseUrl + 'api/products');
  }

}
