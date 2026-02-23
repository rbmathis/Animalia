namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Trachycephalus;

/// <summary>
/// Species: Trachycephalus nigromaculatus
/// NCBI TaxId: 318401
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachycephalus_nigromaculatus : Trachycephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachycephalus nigromaculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachycephalus_nigromaculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318401;
}
