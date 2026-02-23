namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Pitheciidae.Pithecia;

/// <summary>
/// Species: Pithecia sp. MJ-2022
/// NCBI TaxId: 2946524
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pithecia_sp_MJ_2022 : Pithecia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pithecia sp. MJ-2022";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pithecia_sp_MJ_2022";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2946524;
}
