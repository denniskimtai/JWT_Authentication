namespace JWTPractice.Model
{
    public record class JWTOptions
    {
        public string Issuer { get; init; }
        public string Audience { get; init; }
        public string SigningKey { get; init; }
        public int ExpirationSeconds { get; init; }
    }
}
