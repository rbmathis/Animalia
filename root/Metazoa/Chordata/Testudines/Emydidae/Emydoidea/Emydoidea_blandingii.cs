namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Emydoidea;

/// <summary>
/// Species: Emydoidea blandingii
/// NCBI TaxId: 85613
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Emydoidea_blandingii : Emydoidea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Emydoidea blandingii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Emydoidea_blandingii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 85613;
}
