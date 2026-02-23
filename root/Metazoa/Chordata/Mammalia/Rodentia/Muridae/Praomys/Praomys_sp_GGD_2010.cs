namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Praomys;

/// <summary>
/// Species: Praomys sp. GGD-2010
/// NCBI TaxId: 797616
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Praomys_sp_GGD_2010 : Praomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Praomys sp. GGD-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Praomys_sp_GGD_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 797616;
}
