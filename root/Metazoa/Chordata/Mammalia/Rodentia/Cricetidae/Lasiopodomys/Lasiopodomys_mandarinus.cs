namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lasiopodomys;

/// <summary>
/// Species: Lasiopodomys mandarinus
/// NCBI TaxId: 399234
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lasiopodomys_mandarinus : Lasiopodomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lasiopodomys mandarinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lasiopodomys_mandarinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 399234;
}
