namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Stercorariidae.Stercorarius;

/// <summary>
/// Species: Stercorarius sp. Yarmouth
/// NCBI TaxId: 395902
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stercorarius_sp_Yarmouth : Stercorarius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stercorarius sp. Yarmouth";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stercorarius_sp_Yarmouth";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 395902;
}
