namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Deltamys;

/// <summary>
/// Species: Deltamys sp. ALL-2014
/// NCBI TaxId: 1541204
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Deltamys_sp_ALL_2014 : Deltamys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Deltamys sp. ALL-2014";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Deltamys_sp_ALL_2014";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1541204;
}
