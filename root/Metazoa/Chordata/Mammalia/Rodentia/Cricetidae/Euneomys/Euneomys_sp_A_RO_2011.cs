namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Euneomys;

/// <summary>
/// Species: Euneomys sp. A RO-2011
/// NCBI TaxId: 1008161
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Euneomys_sp_A_RO_2011 : Euneomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Euneomys sp. A RO-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Euneomys_sp_A_RO_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1008161;
}
