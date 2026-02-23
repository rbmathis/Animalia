namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brachycephalidae.Brachycephalus;

/// <summary>
/// Species: Brachycephalus pitanga
/// NCBI TaxId: 1030604
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brachycephalus_pitanga : Brachycephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brachycephalus pitanga";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brachycephalus_pitanga";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1030604;
}
