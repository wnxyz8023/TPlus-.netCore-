using System;

namespace Jose
{
	public enum JweAlgorithm
	{
		RSA1_5,
		RSA_OAEP,
		RSA_OAEP_256,
		DIR,
		A128KW,
		A192KW,
		A256KW,
		ECDH_ES,
		ECDH_ES_A128KW,
		ECDH_ES_A192KW,
		ECDH_ES_A256KW,
		PBES2_HS256_A128KW,
		PBES2_HS384_A192KW,
		PBES2_HS512_A256KW,
		A128GCMKW,
		A192GCMKW,
		A256GCMKW
	}
}