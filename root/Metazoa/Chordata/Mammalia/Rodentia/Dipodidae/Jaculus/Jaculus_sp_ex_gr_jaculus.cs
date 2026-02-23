namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Jaculus;

/// <summary>
/// Species: Jaculus sp. 'ex gr jaculus'
/// NCBI TaxId: 2171713
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Jaculus_sp_ex_gr_jaculus : Jaculus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Jaculus sp. 'ex gr jaculus'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Jaculus_sp_ex_gr_jaculus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2171713;
}
