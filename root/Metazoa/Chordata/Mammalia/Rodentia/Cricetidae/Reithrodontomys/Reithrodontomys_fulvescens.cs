namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Reithrodontomys;

/// <summary>
/// Species: Reithrodontomys fulvescens
/// NCBI TaxId: 56213
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Reithrodontomys_fulvescens : Reithrodontomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Reithrodontomys fulvescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Reithrodontomys_fulvescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56213;
}
