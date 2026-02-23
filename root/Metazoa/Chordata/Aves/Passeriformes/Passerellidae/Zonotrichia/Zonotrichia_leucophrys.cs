namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Zonotrichia;

/// <summary>
/// Species: Zonotrichia leucophrys
/// NCBI TaxId: 44393
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Zonotrichia_leucophrys : Zonotrichia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Zonotrichia leucophrys";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Zonotrichia_leucophrys";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44393;
}
