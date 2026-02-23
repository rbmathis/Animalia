namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Afrixalus;

/// <summary>
/// Species: Afrixalus environmental sample
/// NCBI TaxId: 1109613
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Afrixalus_environmental_sample : Afrixalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Afrixalus environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Afrixalus_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1109613;
}
