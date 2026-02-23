namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Nannoscincus;

/// <summary>
/// Species: Nannoscincus sp.
/// NCBI TaxId: 2051855
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nannoscincus_sp : Nannoscincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nannoscincus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nannoscincus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2051855;
}
