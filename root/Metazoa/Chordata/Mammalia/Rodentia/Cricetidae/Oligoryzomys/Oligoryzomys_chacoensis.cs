namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oligoryzomys;

/// <summary>
/// Species: Oligoryzomys chacoensis
/// NCBI TaxId: 37015
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oligoryzomys_chacoensis : Oligoryzomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oligoryzomys chacoensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oligoryzomys_chacoensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37015;
}
