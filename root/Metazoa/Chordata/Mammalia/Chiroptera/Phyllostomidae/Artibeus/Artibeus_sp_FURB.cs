namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Artibeus;

/// <summary>
/// Species: Artibeus sp. FURB
/// NCBI TaxId: 416810
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Artibeus_sp_FURB : Artibeus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Artibeus sp. FURB";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Artibeus_sp_FURB";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 416810;
}
