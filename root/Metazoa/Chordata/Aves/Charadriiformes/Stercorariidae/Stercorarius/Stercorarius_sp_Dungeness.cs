namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Stercorariidae.Stercorarius;

/// <summary>
/// Species: Stercorarius sp. Dungeness
/// NCBI TaxId: 395899
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stercorarius_sp_Dungeness : Stercorarius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stercorarius sp. Dungeness";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stercorarius_sp_Dungeness";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 395899;
}
