namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lygisaurus;

/// <summary>
/// Species: Lygisaurus tanneri
/// NCBI TaxId: 124125
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lygisaurus_tanneri : Lygisaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lygisaurus tanneri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lygisaurus_tanneri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 124125;
}
