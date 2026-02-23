namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis tropidonotus
/// NCBI TaxId: 323608
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_tropidonotus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis tropidonotus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_tropidonotus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 323608;
}
