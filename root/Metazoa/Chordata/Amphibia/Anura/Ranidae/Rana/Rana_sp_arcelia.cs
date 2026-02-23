namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Rana;

/// <summary>
/// Species: Rana sp. 'arcelia'
/// NCBI TaxId: 200792
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rana_sp_arcelia : Rana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rana sp. 'arcelia'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rana_sp_arcelia";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 200792;
}
