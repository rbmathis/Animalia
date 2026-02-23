namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lasiopodomys;

/// <summary>
/// Species: Lasiopodomys anglicus
/// NCBI TaxId: 3029580
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lasiopodomys_anglicus : Lasiopodomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lasiopodomys anglicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lasiopodomys_anglicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3029580;
}
