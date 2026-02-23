namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis pulchellus
/// NCBI TaxId: 40675
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_pulchellus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis pulchellus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_pulchellus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 40675;
}
