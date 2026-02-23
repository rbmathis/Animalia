namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Perca;

/// <summary>
/// Species: Perca flavescens
/// NCBI TaxId: 8167
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Perca_flavescens : Perca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Perca flavescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Perca_flavescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8167;
}
