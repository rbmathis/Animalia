namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Ophisurus;

/// <summary>
/// Species: Ophisurus serpens
/// NCBI TaxId: 1234705
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ophisurus_serpens : Ophisurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ophisurus serpens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ophisurus_serpens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1234705;
}
