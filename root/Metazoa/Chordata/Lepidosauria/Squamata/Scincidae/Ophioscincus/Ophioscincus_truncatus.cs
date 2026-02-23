namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ophioscincus;

/// <summary>
/// Species: Ophioscincus truncatus
/// NCBI TaxId: 405196
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ophioscincus_truncatus : Ophioscincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ophioscincus truncatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ophioscincus_truncatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 405196;
}
