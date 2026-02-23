namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.unclassified_Rodentia;

/// <summary>
/// Species: Rodentia sp. BOLD:AAV6426
/// NCBI TaxId: 1068330
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rodentia_sp_BOLDAAV6426 : unclassified_Rodentia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rodentia sp. BOLD:AAV6426";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rodentia_sp_BOLDAAV6426";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1068330;
}
