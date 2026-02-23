namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Gastrotheca;

/// <summary>
/// Species: Gastrotheca riobambae
/// NCBI TaxId: 8420
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gastrotheca_riobambae : Gastrotheca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gastrotheca riobambae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gastrotheca_riobambae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8420;
}
