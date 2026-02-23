namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis planiceps
/// NCBI TaxId: 1184709
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_planiceps : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis planiceps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_planiceps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1184709;
}
