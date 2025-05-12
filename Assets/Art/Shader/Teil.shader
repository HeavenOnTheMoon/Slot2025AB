Shader "Unlit/Teil"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _ColorTex("ColorTex",2D) = "white" {}
        _NoiseTex("_NoiseTex",2D) = "white"{}
        _Power("Power",Range(0,10))= 1
    }
    SubShader
    {
        Tags { 
                "Queue" = "Transparent"  }
        LOD 100
        Blend SrcAlpha OneMinusSrcAlpha
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                float2 uv_1 :TEXCOORD1;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float2 uv_1 :TEXCOORD1;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            sampler2D _ColorTex;
            float4 _ColorTex_ST;
            float _Power;
            sampler2D _NoiseTex;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                _MainTex_ST.zw = float2(_Time.y,0); 
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                o.uv_1 = TRANSFORM_TEX(v.uv_1, _ColorTex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                fixed4 colTex = tex2D(_ColorTex,i.uv_1);
                fixed4 NoiseTex = tex2D(_NoiseTex,i.uv);
                col.a = col.r;
                col.rgb =1;
                col.rgb*=colTex.rgb;
                col.rgb*=_Power*NoiseTex;
                return col;
            }
            ENDCG
        }
    }
}
