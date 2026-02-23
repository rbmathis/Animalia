namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Nannoscincus;

/// <summary>
/// Species: Nannoscincus fuscus
/// NCBI TaxId: 1277980
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nannoscincus_fuscus : Nannoscincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nannoscincus fuscus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nannoscincus_fuscus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1277980;
}
