namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Komodomys;

/// <summary>
/// Species: Komodomys rintjanus
/// NCBI TaxId: 1799708
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Komodomys_rintjanus : Komodomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Komodomys rintjanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Komodomys_rintjanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1799708;
}
