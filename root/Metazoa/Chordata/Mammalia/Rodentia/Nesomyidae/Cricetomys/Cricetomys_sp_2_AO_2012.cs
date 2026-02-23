namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Cricetomys;

/// <summary>
/// Species: Cricetomys sp. 2 AO-2012
/// NCBI TaxId: 1157643
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cricetomys_sp_2_AO_2012 : Cricetomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cricetomys sp. 2 AO-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cricetomys_sp_2_AO_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1157643;
}
