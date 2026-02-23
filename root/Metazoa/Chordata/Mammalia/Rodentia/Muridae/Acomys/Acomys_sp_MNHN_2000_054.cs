namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Acomys;

/// <summary>
/// Species: Acomys sp. MNHN 2000-054
/// NCBI TaxId: 333391
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acomys_sp_MNHN_2000_054 : Acomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acomys sp. MNHN 2000-054";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acomys_sp_MNHN_2000_054";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 333391;
}
