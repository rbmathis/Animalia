namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.unclassified_Carnivora;

/// <summary>
/// Species: Carnivora sp. BOLD:AAE9178
/// NCBI TaxId: 816547
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carnivora_sp_BOLDAAE9178 : unclassified_Carnivora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carnivora sp. BOLD:AAE9178";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carnivora_sp_BOLDAAE9178";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 816547;
}
