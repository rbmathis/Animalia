namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufo;

/// <summary>
/// Species: Bufo tuberculatus
/// NCBI TaxId: 103438
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bufo_tuberculatus : Bufo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bufo tuberculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bufo_tuberculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 103438;
}
