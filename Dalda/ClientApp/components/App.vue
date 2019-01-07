<template>
    <div>
        <router-view></router-view>
    </div>
</template>
<style>
    p, ul {
        margin: 0px;
    }

    li {
        padding: 0px;
        list-style: none;
    }

    a {
        color: black;
        text-decoration: none;
    }

    h1 {
        font-size: 20px;
    }

    h2 {
        font-size: 18px;
    }

    h3 {
        font-size: 16px;
    }

    h4 {
        font-size: 14px;
    }

    h5 {
        font-size: 12px;
    }

    h6 {
        font-size: 11px;
    }
</style>

<script>
export default {
    name: 'app',
    data () {
        return {
            time: new Date().toString(),
            users: []
        }
    },
    mounted () {
        fetch('/api/users')
        .then(response => {
        return response.json()
    }).then(data => {
            this.users = data
        })
    }
}
</script>