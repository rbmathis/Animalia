namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Parotomys;

/// <summary>
/// Species: Parotomys littledalei
/// NCBI TaxId: 121579
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Parotomys_littledalei : Parotomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Parotomys littledalei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Parotomys_littledalei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 121579;
}
