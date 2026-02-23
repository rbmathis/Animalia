namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.unclassified_Mammalia;

/// <summary>
/// Species: Mammalia sp. MMA-2019
/// NCBI TaxId: 2598437
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mammalia_sp_MMA_2019 : unclassified_Mammalia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mammalia sp. MMA-2019";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mammalia_sp_MMA_2019";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2598437;
}
