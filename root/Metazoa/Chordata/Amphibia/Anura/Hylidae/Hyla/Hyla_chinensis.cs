namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla chinensis
/// NCBI TaxId: 167933
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_chinensis : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla chinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_chinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 167933;
}
