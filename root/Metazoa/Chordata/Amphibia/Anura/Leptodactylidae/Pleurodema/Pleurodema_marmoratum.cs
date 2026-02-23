namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Pleurodema;

/// <summary>
/// Species: Pleurodema marmoratum
/// NCBI TaxId: 332565
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pleurodema_marmoratum : Pleurodema
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pleurodema marmoratum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pleurodema_marmoratum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 332565;
}
