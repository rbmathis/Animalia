namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Pseudis;

/// <summary>
/// Species: Pseudis platensis
/// NCBI TaxId: 2743159
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudis_platensis : Pseudis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudis platensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudis_platensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2743159;
}
