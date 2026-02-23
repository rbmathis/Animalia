namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Petrus;

/// <summary>
/// Species: Petrus rupestris
/// NCBI TaxId: 119732
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petrus_rupestris : Petrus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petrus rupestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petrus_rupestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 119732;
}
