namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Nannoscincus;

/// <summary>
/// Species: Nannoscincus gracilis
/// NCBI TaxId: 394154
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nannoscincus_gracilis : Nannoscincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nannoscincus gracilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nannoscincus_gracilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 394154;
}
