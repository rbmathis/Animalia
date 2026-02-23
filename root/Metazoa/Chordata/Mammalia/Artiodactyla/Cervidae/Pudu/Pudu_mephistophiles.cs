namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Pudu;

/// <summary>
/// Species: Pudu mephistophiles
/// NCBI TaxId: 1088059
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pudu_mephistophiles : Pudu
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pudu mephistophiles";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pudu_mephistophiles";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1088059;
}
