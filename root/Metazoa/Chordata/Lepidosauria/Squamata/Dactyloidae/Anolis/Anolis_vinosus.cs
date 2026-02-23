namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis vinosus
/// NCBI TaxId: 2961827
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_vinosus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis vinosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_vinosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2961827;
}
