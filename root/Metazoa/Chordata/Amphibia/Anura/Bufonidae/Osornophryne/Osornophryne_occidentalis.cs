namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Osornophryne;

/// <summary>
/// Species: Osornophryne occidentalis
/// NCBI TaxId: 1077865
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Osornophryne_occidentalis : Osornophryne
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Osornophryne occidentalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Osornophryne_occidentalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1077865;
}
