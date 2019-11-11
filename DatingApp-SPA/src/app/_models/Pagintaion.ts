export class Pagintaion {
    currentPage: number;
    itemPerPage: number;
    totalItems: number;
    totalPages: number;
}

export class PagintedResult<T> {
    result: T;
    pagination: Pagintaion;
}
