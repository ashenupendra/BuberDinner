#Buber Dinner API

- [Buber Diner API](#Buber-Dinner-API)
    - [Auth](#Auth)
        - [Register](#Register)
            - [Register Request](#Register-Request)
            - [Register Response](#Register-Response)
        - [Login](#Register)
            - [Login Request](#Login-Request)
            - [Login Response](#Login-Response)

## Auth

## Register

```js
POST {{host}}/auth/regiser
```

#### Register Request


```json
{
    "firstName": "Ashen",
    "lastName": "Disanayaka",
    "email": "ashenupendra@gmail.com",
    "password": "Word@pass1234"
}
```

#### Register Response

```js
200 Ok
```

```json
{
    "id": "",
    "firstName": "Ashen",
    "lastName": "Disanayaka",
    "email": "ashenupendra@gmail.com",
    "token": "eyJhb..hbbQ"
}
```

## Login

#### Login Request

```json
{
    "email": "ashenupendra@gmail.com",
    "password": "Word@pass1234"
}
```

#### Login Response

```js
200 Ok
```

```json
{
    "id": "",
    "firstName": "Ashen",
    "lastName": "Disanayaka",
    "email": "ashenupendra@gmail.com",
    "token": "eyJhb..hbbQ"
}
```
