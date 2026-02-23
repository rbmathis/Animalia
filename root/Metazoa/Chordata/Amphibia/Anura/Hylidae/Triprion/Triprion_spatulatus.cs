namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Triprion;

/// <summary>
/// Species: Triprion spatulatus
/// NCBI TaxId: 373085
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Triprion_spatulatus : Triprion
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Triprion spatulatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Triprion_spatulatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 373085;
}
