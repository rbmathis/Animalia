namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Spalax;

/// <summary>
/// Species: Spalax sp. MMS-2006
/// NCBI TaxId: 368737
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spalax_sp_MMS_2006 : Spalax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spalax sp. MMS-2006";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spalax_sp_MMS_2006";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 368737;
}
