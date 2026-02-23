namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oligoryzomys;

/// <summary>
/// Species: Oligoryzomys flavescens
/// NCBI TaxId: 218824
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oligoryzomys_flavescens : Oligoryzomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oligoryzomys flavescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oligoryzomys_flavescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 218824;
}
