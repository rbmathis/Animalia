namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Myomyscus;

/// <summary>
/// Species: Myomyscus verreauxii
/// NCBI TaxId: 485438
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myomyscus_verreauxii : Myomyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myomyscus verreauxii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myomyscus_verreauxii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 485438;
}
