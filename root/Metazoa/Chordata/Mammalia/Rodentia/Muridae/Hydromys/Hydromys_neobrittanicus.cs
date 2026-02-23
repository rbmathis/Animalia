namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hydromys;

/// <summary>
/// Species: Hydromys neobrittanicus
/// NCBI TaxId: 160451
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hydromys_neobrittanicus : Hydromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hydromys neobrittanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hydromys_neobrittanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 160451;
}
