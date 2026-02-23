namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felis;

/// <summary>
/// Species: Felis silvestris
/// NCBI TaxId: 9683
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Felis_silvestris : Felis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Felis silvestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Felis_silvestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9683;
}
