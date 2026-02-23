namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Murina;

/// <summary>
/// Species: Murina sp. HZ-2008
/// NCBI TaxId: 584771
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Murina_sp_HZ_2008 : Murina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Murina sp. HZ-2008";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Murina_sp_HZ_2008";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 584771;
}
