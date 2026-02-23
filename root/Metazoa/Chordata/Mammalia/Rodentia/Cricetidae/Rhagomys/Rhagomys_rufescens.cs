namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Rhagomys;

/// <summary>
/// Species: Rhagomys rufescens
/// NCBI TaxId: 221579
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhagomys_rufescens : Rhagomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhagomys rufescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhagomys_rufescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 221579;
}
