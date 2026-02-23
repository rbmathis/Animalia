namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Paedophryne;

/// <summary>
/// Species: Paedophryne swiftorum
/// NCBI TaxId: 1075811
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Paedophryne_swiftorum : Paedophryne
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Paedophryne swiftorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Paedophryne_swiftorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1075811;
}
