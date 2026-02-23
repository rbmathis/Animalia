namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Gastrotheca;

/// <summary>
/// Species: Gastrotheca testudinea
/// NCBI TaxId: 1329507
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gastrotheca_testudinea : Gastrotheca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gastrotheca testudinea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gastrotheca_testudinea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1329507;
}
