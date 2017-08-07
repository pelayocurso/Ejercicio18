describe("A suite", function () {
    it("contains spec with an expectation", function () {
        expect(true).toBe(true);
    });
});

describe("A suite 2", function () {
    var resultado;

    it('prueba de sesion REST', function (done) {
        $.get('api/values/5', function (data) {
            resultado = data;
            done();
        });
    });

    afterEach(function (done) {
        expect(resultado).toBe("value");
        done();
    }, 1000);
});

describe("CRUD Create Test", function () {
    var resultado;

    it('prueba de sesion REST', function (done) {
        $.get('api/Entradas', function (data) {
            resultado = data;
            done();
        });
    });

    afterEach(function (done) {
        //expect(resultado).toBe("value");
        expect(resultado.Id).toBeGreaterThan(0);
        done();
    }, 1000);
});

describe("CRUD Read Test", function () {
    var resultado;

    it('prueba de sesion REST', function (done) {
        $.get('api/Entradas/1', function (data) {
            resultado = data;
            done();
        });
    });

    afterEach(function (done) {
        expect(resultado).toBeDefined();
        expect(resultado.Id).toBeGreaterThan(0);
        done();
    }, 1000);
});

describe("CRUD Update Test", function () {
    var resultado;

    var datos = {
        Precio: 15
    };
    it('prueba de sesion REST', function (done) {
        $.ajax('api/Entradas/1', function (data) {
            resultado = data;
            done();
        });
    });

    afterEach(function (done) {
        expect(resultado).toBe("value");
        done();
    }, 1000);
});

describe("CRUD Delete Test", function () {
    var resultado;

    it('prueba de sesion REST', function (done) {
        $.ajax('api/Entradas/5', function (data) {
            resultado = data;
            done();
        });
    });

    afterEach(function (done) {
        expect(resultado).toBe("value");
        done();
    }, 1000);
});