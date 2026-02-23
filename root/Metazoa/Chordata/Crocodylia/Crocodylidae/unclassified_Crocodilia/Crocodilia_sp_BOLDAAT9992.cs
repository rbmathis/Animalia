namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.unclassified_Crocodilia;

/// <summary>
/// Species: Crocodilia sp. BOLD:AAT9992
/// NCBI TaxId: 1067860
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Crocodilia_sp_BOLDAAT9992 : unclassified_Crocodilia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Crocodilia sp. BOLD:AAT9992";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Crocodilia_sp_BOLDAAT9992";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1067860;
}
