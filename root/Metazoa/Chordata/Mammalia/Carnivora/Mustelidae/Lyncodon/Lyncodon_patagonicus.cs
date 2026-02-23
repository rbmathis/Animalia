namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Lyncodon;

/// <summary>
/// Species: Lyncodon patagonicus
/// NCBI TaxId: 768574
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lyncodon_patagonicus : Lyncodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lyncodon patagonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lyncodon_patagonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 768574;
}
