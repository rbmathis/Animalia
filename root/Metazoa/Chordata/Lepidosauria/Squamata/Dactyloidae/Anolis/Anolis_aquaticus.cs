namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis aquaticus
/// NCBI TaxId: 323567
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_aquaticus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis aquaticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_aquaticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 323567;
}
