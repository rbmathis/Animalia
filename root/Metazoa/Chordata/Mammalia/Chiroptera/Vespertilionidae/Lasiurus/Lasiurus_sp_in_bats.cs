namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Lasiurus;

/// <summary>
/// Species: Lasiurus sp. (in: bats)
/// NCBI TaxId: 160977
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lasiurus_sp_in_bats : Lasiurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lasiurus sp. (in: bats)";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lasiurus_sp_in_bats";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 160977;
}
