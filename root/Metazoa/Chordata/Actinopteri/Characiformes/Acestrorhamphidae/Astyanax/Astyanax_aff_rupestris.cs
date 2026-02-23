namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Astyanax;

/// <summary>
/// Species: Astyanax aff. rupestris
/// NCBI TaxId: 3082105
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Astyanax_aff_rupestris : Astyanax
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Astyanax aff. rupestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Astyanax_aff_rupestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3082105;
}
