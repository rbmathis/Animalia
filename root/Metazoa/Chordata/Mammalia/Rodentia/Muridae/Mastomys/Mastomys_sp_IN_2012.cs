namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mastomys;

/// <summary>
/// Species: Mastomys sp. IN-2012
/// NCBI TaxId: 1239840
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mastomys_sp_IN_2012 : Mastomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mastomys sp. IN-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mastomys_sp_IN_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1239840;
}
