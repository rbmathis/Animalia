namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Stercorariidae.Stercorarius;

/// <summary>
/// Species: Stercorarius sp. Sussex
/// NCBI TaxId: 395901
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stercorarius_sp_Sussex : Stercorarius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stercorarius sp. Sussex";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stercorarius_sp_Sussex";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 395901;
}
