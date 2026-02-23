namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Molossus;

/// <summary>
/// Species: Molossus sp.
/// NCBI TaxId: 3041509
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Molossus_sp : Molossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Molossus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Molossus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3041509;
}
