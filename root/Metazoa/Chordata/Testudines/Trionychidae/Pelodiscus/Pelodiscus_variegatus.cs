namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Pelodiscus;

/// <summary>
/// Species: Pelodiscus variegatus
/// NCBI TaxId: 3119847
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelodiscus_variegatus : Pelodiscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelodiscus variegatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelodiscus_variegatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3119847;
}
