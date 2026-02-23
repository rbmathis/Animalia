namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Stercorariidae.Stercorarius;

/// <summary>
/// Species: Stercorarius antarcticus
/// NCBI TaxId: 555350
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stercorarius_antarcticus : Stercorarius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stercorarius antarcticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stercorarius_antarcticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 555350;
}
