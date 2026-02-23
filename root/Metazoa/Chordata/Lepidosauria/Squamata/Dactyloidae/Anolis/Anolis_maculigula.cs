namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis maculigula
/// NCBI TaxId: 1091120
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_maculigula : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis maculigula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_maculigula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1091120;
}
