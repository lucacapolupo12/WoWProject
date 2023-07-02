require('dotenv').config()
const querystring = require('node:querystring');
const fs = require('fs');
// const { setTimeout } = require('node:timers/promises');

// fetch(process.env.base_url + 'clans/info/?' + querystring.encode({ application_id: process.env.application_id, clan_id: process.env.clan_id }))
//     .then(data => data.json())
//     .then(data => {
//         console.log(data)
//         fs.writeFileSync('clan.json', JSON.stringify(data))
//     })

// const clan = require('./clan.json').data[500140057]
// let members_ids = clan.members_ids

// let arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]

// console.log(members_ids)
// setInterval(() => {

//     // const account_id = members_ids[members_ids.length - 1]
//     const page_no = arr[arr.length - 1]
//     fetch(process.env.base_url + 'encyclopedia/ships/?' + querystring.encode({ application_id: process.env.application_id, page_no }))
//         // fetch(process.env.base_url + 'account/info/?' + querystring.encode({ application_id: process.env.application_id, account_id }))
//         .then(data => data.json())
//         .then(data => {
//             fs.writeFileSync(`${page_no}-ships.json`, JSON.stringify(data))
//         })
//     // members_ids.pop()
//     arr.pop()
// }, 100)


const { path } = require('path')

let fileArr = fs.readdirSync('../accounts')

// fileArr.forEach(f => {
//     let file = JSON.parse(fs.readFileSync('../accounts/' + f))
//     file = file.data[Object.keys(file.data)[0]]
//     console.log(file)
//     fs.writeFileSync(`${file.nickname}.json`, JSON.stringify(file))
// })
fileArr.forEach(f => {
    let file = JSON.parse(fs.readFileSync('../accounts/' + f))
    let accId = file.account_id
    let ships = JSON.parse(fs.readFileSync('../ships/' + accId + '-ships.json'))
    ships = ships.data[Object.keys(ships.data)[0]]
    file.ships = ships
    fs.writeFileSync(`../accounts/${file.nickname}.json`, JSON.stringify(file))
})