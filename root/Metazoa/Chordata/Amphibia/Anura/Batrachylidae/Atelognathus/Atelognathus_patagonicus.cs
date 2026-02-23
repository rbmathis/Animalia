namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Batrachylidae.Atelognathus;

/// <summary>
/// Species: Atelognathus patagonicus
/// NCBI TaxId: 318267
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Atelognathus_patagonicus : Atelognathus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Atelognathus patagonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Atelognathus_patagonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318267;
}
