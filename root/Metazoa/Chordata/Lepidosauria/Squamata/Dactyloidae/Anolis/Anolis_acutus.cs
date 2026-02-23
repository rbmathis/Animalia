namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis acutus
/// NCBI TaxId: 75240
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_acutus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis acutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_acutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75240;
}
