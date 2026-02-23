namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Pelodiscus;

/// <summary>
/// Species: Pelodiscus parviformis
/// NCBI TaxId: 947008
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelodiscus_parviformis : Pelodiscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelodiscus parviformis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelodiscus_parviformis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 947008;
}
