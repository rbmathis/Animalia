namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neacomys;

/// <summary>
/// Species: Neacomys sp. 'clade 7'
/// NCBI TaxId: 1962397
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neacomys_sp_clade_7 : Neacomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neacomys sp. 'clade 7'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neacomys_sp_clade_7";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1962397;
}
