namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Artibeus;

/// <summary>
/// Species: Artibeus hirsutus
/// NCBI TaxId: 51012
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Artibeus_hirsutus : Artibeus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Artibeus hirsutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Artibeus_hirsutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 51012;
}
