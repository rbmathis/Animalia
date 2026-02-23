namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Porphyrio;

/// <summary>
/// Species: Porphyrio flavirostris
/// NCBI TaxId: 555331
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Porphyrio_flavirostris : Porphyrio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Porphyrio flavirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Porphyrio_flavirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 555331;
}
