namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Maxomys;

/// <summary>
/// Species: Maxomys moi
/// NCBI TaxId: 1003209
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Maxomys_moi : Maxomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Maxomys moi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Maxomys_moi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1003209;
}
