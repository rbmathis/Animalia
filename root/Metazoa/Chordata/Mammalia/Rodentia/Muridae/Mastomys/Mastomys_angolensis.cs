namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mastomys;

/// <summary>
/// Species: Mastomys angolensis
/// NCBI TaxId: 2819595
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mastomys_angolensis : Mastomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mastomys angolensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mastomys_angolensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2819595;
}
