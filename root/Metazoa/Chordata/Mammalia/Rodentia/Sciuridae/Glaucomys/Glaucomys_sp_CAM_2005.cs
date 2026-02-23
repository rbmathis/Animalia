namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Glaucomys;

/// <summary>
/// Species: Glaucomys sp. CAM-2005
/// NCBI TaxId: 363600
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Glaucomys_sp_CAM_2005 : Glaucomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Glaucomys sp. CAM-2005";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Glaucomys_sp_CAM_2005";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 363600;
}
