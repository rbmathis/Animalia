namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae.Spea;

/// <summary>
/// Species: Spea multiplicata
/// NCBI TaxId: 30317
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spea_multiplicata : Spea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spea multiplicata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spea_multiplicata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30317;
}
