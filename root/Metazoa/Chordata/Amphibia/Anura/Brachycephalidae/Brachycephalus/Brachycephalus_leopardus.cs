namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brachycephalidae.Brachycephalus;

/// <summary>
/// Species: Brachycephalus leopardus
/// NCBI TaxId: 1843541
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brachycephalus_leopardus : Brachycephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brachycephalus leopardus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brachycephalus_leopardus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1843541;
}
