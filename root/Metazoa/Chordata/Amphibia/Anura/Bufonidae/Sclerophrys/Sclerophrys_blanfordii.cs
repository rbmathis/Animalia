namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Sclerophrys;

/// <summary>
/// Species: Sclerophrys blanfordii
/// NCBI TaxId: 1978133
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sclerophrys_blanfordii : Sclerophrys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sclerophrys blanfordii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sclerophrys_blanfordii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1978133;
}
