namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae.Spea;

/// <summary>
/// Species: Spea bombifrons
/// NCBI TaxId: 233779
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spea_bombifrons : Spea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spea bombifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spea_bombifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 233779;
}
