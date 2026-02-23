namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis blanquillanus
/// NCBI TaxId: 2268912
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_blanquillanus : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis blanquillanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_blanquillanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2268912;
}
