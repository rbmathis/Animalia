namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamiasciurus;

/// <summary>
/// Species: Tamiasciurus hudsonicus
/// NCBI TaxId: 10009
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tamiasciurus_hudsonicus : Tamiasciurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tamiasciurus hudsonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tamiasciurus_hudsonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10009;
}
