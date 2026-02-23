namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.unclassified_Rodentia;

/// <summary>
/// Species: Rodentia sp. BOLD:AAA7810
/// NCBI TaxId: 976549
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rodentia_sp_BOLDAAA7810 : unclassified_Rodentia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rodentia sp. BOLD:AAA7810";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rodentia_sp_BOLDAAA7810";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 976549;
}
