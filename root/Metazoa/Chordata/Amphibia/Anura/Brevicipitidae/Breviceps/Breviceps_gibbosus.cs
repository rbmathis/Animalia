namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Breviceps;

/// <summary>
/// Species: Breviceps gibbosus
/// NCBI TaxId: 1658250
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Breviceps_gibbosus : Breviceps
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Breviceps gibbosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Breviceps_gibbosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1658250;
}
