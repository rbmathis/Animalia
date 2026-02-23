namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis poecilopus
/// NCBI TaxId: 323597
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_poecilopus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis poecilopus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_poecilopus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 323597;
}
