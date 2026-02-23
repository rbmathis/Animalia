namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Prosciurillus;

/// <summary>
/// Species: Prosciurillus leucomus
/// NCBI TaxId: 1655508
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Prosciurillus_leucomus : Prosciurillus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Prosciurillus leucomus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Prosciurillus_leucomus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1655508;
}
