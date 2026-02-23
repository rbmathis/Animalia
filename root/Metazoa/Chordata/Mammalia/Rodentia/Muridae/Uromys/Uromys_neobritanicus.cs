namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Uromys;

/// <summary>
/// Species: Uromys neobritanicus
/// NCBI TaxId: 301547
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Uromys_neobritanicus : Uromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Uromys neobritanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Uromys_neobritanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 301547;
}
