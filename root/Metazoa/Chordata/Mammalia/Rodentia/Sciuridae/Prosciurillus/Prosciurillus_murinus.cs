namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Prosciurillus;

/// <summary>
/// Species: Prosciurillus murinus
/// NCBI TaxId: 226567
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Prosciurillus_murinus : Prosciurillus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Prosciurillus murinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Prosciurillus_murinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 226567;
}
