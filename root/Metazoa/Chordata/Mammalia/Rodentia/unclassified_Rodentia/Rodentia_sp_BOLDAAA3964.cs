namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.unclassified_Rodentia;

/// <summary>
/// Species: Rodentia sp. BOLD:AAA3964
/// NCBI TaxId: 924707
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rodentia_sp_BOLDAAA3964 : unclassified_Rodentia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rodentia sp. BOLD:AAA3964";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rodentia_sp_BOLDAAA3964";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 924707;
}
