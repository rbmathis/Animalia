namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Otomys;

/// <summary>
/// Species: Otomys auratus
/// NCBI TaxId: 2987636
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otomys_auratus : Otomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otomys auratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otomys_auratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2987636;
}
