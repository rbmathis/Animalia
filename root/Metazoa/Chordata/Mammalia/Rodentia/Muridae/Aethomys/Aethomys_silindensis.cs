namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Aethomys;

/// <summary>
/// Species: Aethomys silindensis
/// NCBI TaxId: 1890050
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aethomys_silindensis : Aethomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aethomys silindensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aethomys_silindensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1890050;
}
