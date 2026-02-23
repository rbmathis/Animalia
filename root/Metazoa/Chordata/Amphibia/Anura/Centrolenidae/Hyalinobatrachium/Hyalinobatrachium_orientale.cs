namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Hyalinobatrachium;

/// <summary>
/// Species: Hyalinobatrachium orientale
/// NCBI TaxId: 505721
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyalinobatrachium_orientale : Hyalinobatrachium
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyalinobatrachium orientale";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyalinobatrachium_orientale";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 505721;
}
