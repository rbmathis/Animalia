namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mastomys;

/// <summary>
/// Species: Mastomys sp.
/// NCBI TaxId: 70830
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mastomys_sp : Mastomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mastomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mastomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 70830;
}
