namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Rallus;

/// <summary>
/// Species: Rallus tenuirostris
/// NCBI TaxId: 1567166
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rallus_tenuirostris : Rallus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rallus tenuirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rallus_tenuirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1567166;
}
