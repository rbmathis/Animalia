namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Hydrophylax;

/// <summary>
/// Species: Hydrophylax leptoglossa
/// NCBI TaxId: 1659774
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hydrophylax_leptoglossa : Hydrophylax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hydrophylax leptoglossa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hydrophylax_leptoglossa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1659774;
}
