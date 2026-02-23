namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Pseudois;

/// <summary>
/// Species: Pseudois sp. DL
/// NCBI TaxId: 1221214
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudois_sp_DL : Pseudois
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudois sp. DL";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudois_sp_DL";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1221214;
}
