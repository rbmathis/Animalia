namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhinodermatidae.Rhinoderma;

/// <summary>
/// Species: Rhinoderma darwinii
/// NCBI TaxId: 43563
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinoderma_darwinii : Rhinoderma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinoderma darwinii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinoderma_darwinii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43563;
}
