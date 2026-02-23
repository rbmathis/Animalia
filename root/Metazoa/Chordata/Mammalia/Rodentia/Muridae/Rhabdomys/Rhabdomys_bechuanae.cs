namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rhabdomys;

/// <summary>
/// Species: Rhabdomys bechuanae
/// NCBI TaxId: 2316664
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhabdomys_bechuanae : Rhabdomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhabdomys bechuanae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhabdomys_bechuanae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2316664;
}
