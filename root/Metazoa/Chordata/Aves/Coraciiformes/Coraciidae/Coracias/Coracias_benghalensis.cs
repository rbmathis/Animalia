namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Coraciidae.Coracias;

/// <summary>
/// Species: Coracias benghalensis
/// NCBI TaxId: 1343485
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coracias_benghalensis : Coracias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coracias benghalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coracias_benghalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1343485;
}
