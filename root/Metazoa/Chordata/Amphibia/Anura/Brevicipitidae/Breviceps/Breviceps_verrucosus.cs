namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Breviceps;

/// <summary>
/// Species: Breviceps verrucosus
/// NCBI TaxId: 2304180
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Breviceps_verrucosus : Breviceps
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Breviceps verrucosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Breviceps_verrucosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2304180;
}
