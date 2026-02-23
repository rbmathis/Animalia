namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Sphenophryne;

/// <summary>
/// Species: Sphenophryne dentata
/// NCBI TaxId: 480198
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphenophryne_dentata : Sphenophryne
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphenophryne dentata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphenophryne_dentata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 480198;
}
