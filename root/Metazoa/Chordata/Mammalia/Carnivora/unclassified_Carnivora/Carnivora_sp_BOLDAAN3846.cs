namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.unclassified_Carnivora;

/// <summary>
/// Species: Carnivora sp. BOLD:AAN3846
/// NCBI TaxId: 974062
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carnivora_sp_BOLDAAN3846 : unclassified_Carnivora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carnivora sp. BOLD:AAN3846";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carnivora_sp_BOLDAAN3846";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 974062;
}
