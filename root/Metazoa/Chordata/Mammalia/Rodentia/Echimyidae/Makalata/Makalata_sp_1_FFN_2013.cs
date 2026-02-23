namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Makalata;

/// <summary>
/// Species: Makalata sp. 1 FFN-2013
/// NCBI TaxId: 1341610
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Makalata_sp_1_FFN_2013 : Makalata
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Makalata sp. 1 FFN-2013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Makalata_sp_1_FFN_2013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1341610;
}
