namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Nyctomys;

/// <summary>
/// Species: Nyctomys sumichrasti
/// NCBI TaxId: 56227
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctomys_sumichrasti : Nyctomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctomys sumichrasti";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctomys_sumichrasti";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56227;
}
