namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Haeromys;

/// <summary>
/// Species: Haeromys minahassae
/// NCBI TaxId: 2683856
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Haeromys_minahassae : Haeromys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Haeromys minahassae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Haeromys_minahassae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2683856;
}
