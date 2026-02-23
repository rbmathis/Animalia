namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hylomyscus;

/// <summary>
/// Species: Hylomyscus sp. 1 TCD-2013
/// NCBI TaxId: 1427143
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylomyscus_sp_1_TCD_2013 : Hylomyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylomyscus sp. 1 TCD-2013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylomyscus_sp_1_TCD_2013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1427143;
}
