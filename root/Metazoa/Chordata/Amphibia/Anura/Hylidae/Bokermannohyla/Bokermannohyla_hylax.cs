namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Bokermannohyla;

/// <summary>
/// Species: Bokermannohyla hylax
/// NCBI TaxId: 279999
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bokermannohyla_hylax : Bokermannohyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bokermannohyla hylax";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bokermannohyla_hylax";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 279999;
}
