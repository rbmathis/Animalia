namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis barbatus
/// NCBI TaxId: 235286
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_barbatus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis barbatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_barbatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 235286;
}
