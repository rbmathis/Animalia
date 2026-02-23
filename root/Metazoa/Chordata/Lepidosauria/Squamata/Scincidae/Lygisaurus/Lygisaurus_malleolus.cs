namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lygisaurus;

/// <summary>
/// Species: Lygisaurus malleolus
/// NCBI TaxId: 273487
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lygisaurus_malleolus : Lygisaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lygisaurus malleolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lygisaurus_malleolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 273487;
}
