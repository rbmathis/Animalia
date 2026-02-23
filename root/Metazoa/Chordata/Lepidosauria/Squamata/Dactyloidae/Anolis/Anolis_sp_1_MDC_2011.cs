namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

/// <summary>
/// Species: Anolis sp. 1 MDC-2011
/// NCBI TaxId: 1091129
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anolis_sp_1_MDC_2011 : Anolis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anolis sp. 1 MDC-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anolis_sp_1_MDC_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1091129;
}
