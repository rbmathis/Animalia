namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Leptosciurus;

/// <summary>
/// Species: Leptosciurus pucheranii
/// NCBI TaxId: 2749098
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptosciurus_pucheranii : Leptosciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptosciurus pucheranii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptosciurus_pucheranii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2749098;
}
