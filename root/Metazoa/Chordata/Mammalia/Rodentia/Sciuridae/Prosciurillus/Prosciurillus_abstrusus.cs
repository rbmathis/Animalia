namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Prosciurillus;

/// <summary>
/// Species: Prosciurillus abstrusus
/// NCBI TaxId: 1655507
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Prosciurillus_abstrusus : Prosciurillus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Prosciurillus abstrusus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Prosciurillus_abstrusus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1655507;
}
