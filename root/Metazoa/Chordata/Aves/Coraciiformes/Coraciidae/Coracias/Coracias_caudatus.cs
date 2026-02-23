namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Coraciidae.Coracias;

/// <summary>
/// Species: Coracias caudatus
/// NCBI TaxId: 56292
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coracias_caudatus : Coracias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coracias caudatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coracias_caudatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56292;
}
