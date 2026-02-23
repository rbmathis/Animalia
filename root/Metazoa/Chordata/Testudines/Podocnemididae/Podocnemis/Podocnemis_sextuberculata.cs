namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Podocnemis;

/// <summary>
/// Species: Podocnemis sextuberculata
/// NCBI TaxId: 510613
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Podocnemis_sextuberculata : Podocnemis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Podocnemis sextuberculata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Podocnemis_sextuberculata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 510613;
}
