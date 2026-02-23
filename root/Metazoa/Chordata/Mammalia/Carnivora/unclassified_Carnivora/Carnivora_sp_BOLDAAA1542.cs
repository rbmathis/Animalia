namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.unclassified_Carnivora;

/// <summary>
/// Species: Carnivora sp. BOLD:AAA1542
/// NCBI TaxId: 816535
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carnivora_sp_BOLDAAA1542 : unclassified_Carnivora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carnivora sp. BOLD:AAA1542";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carnivora_sp_BOLDAAA1542";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 816535;
}
