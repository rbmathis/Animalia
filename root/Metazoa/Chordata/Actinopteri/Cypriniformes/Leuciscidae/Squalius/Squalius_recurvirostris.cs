namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Squalius;

/// <summary>
/// Species: Squalius recurvirostris
/// NCBI TaxId: 1483146
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalius_recurvirostris : Squalius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalius recurvirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalius_recurvirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1483146;
}
