namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Xerus;

/// <summary>
/// Species: Xerus rutilus
/// NCBI TaxId: 226860
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xerus_rutilus : Xerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xerus rutilus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xerus_rutilus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 226860;
}
