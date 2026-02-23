namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyla;

/// <summary>
/// Species: Hyla meridionalis
/// NCBI TaxId: 272192
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyla_meridionalis : Hyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyla meridionalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyla_meridionalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 272192;
}
