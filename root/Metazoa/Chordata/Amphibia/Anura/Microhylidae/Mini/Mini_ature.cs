namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Mini;

/// <summary>
/// Species: Mini ature
/// NCBI TaxId: 3070230
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mini_ature : Mini
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mini ature";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mini_ature";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3070230;
}
