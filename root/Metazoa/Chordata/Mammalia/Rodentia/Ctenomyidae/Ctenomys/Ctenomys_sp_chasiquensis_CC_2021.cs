namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenomyidae.Ctenomys;

/// <summary>
/// Species: Ctenomys sp. 'chasiquensis' CC-2021
/// NCBI TaxId: 2872532
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ctenomys_sp_chasiquensis_CC_2021 : Ctenomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ctenomys sp. 'chasiquensis' CC-2021";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ctenomys_sp_chasiquensis_CC_2021";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2872532;
}
