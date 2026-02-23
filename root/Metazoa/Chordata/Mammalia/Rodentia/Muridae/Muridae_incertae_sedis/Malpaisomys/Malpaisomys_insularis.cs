namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Muridae_incertae_sedis.Malpaisomys;

/// <summary>
/// Species: Malpaisomys insularis
/// NCBI TaxId: 1211276
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Malpaisomys_insularis : Malpaisomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Malpaisomys insularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Malpaisomys_insularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1211276;
}
