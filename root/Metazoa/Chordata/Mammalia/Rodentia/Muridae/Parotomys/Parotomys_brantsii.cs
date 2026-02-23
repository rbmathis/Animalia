namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Parotomys;

/// <summary>
/// Species: Parotomys brantsii
/// NCBI TaxId: 121578
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Parotomys_brantsii : Parotomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Parotomys brantsii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Parotomys_brantsii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 121578;
}
