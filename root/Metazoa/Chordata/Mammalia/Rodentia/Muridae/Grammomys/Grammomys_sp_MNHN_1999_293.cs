namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Grammomys;

/// <summary>
/// Species: Grammomys sp. MNHN 1999-293
/// NCBI TaxId: 333392
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Grammomys_sp_MNHN_1999_293 : Grammomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Grammomys sp. MNHN 1999-293";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Grammomys_sp_MNHN_1999_293";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 333392;
}
