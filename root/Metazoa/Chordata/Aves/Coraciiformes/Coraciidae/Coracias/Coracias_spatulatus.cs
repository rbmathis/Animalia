namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Coraciidae.Coracias;

/// <summary>
/// Species: Coracias spatulatus
/// NCBI TaxId: 1547491
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coracias_spatulatus : Coracias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coracias spatulatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coracias_spatulatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1547491;
}
