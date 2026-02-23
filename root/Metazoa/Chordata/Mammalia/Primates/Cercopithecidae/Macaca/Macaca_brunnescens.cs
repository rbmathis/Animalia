namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Macaca;

/// <summary>
/// Species: Macaca brunnescens
/// NCBI TaxId: 90381
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macaca_brunnescens : Macaca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macaca brunnescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macaca_brunnescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 90381;
}
