namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae.Trachipterus;

/// <summary>
/// Species: Trachipterus jacksonensis
/// NCBI TaxId: 81395
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachipterus_jacksonensis : Trachipterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachipterus jacksonensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachipterus_jacksonensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 81395;
}
