namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Corvus;

/// <summary>
/// Species: Corvus brachyrhynchos
/// NCBI TaxId: 85066
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Corvus_brachyrhynchos : Corvus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Corvus brachyrhynchos";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Corvus_brachyrhynchos";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 85066;
}
