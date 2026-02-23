namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Myodes;

/// <summary>
/// Species: Myodes sp. YY-2015
/// NCBI TaxId: 1665533
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myodes_sp_YY_2015 : Myodes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myodes sp. YY-2015";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myodes_sp_YY_2015";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1665533;
}
