namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Myotis;

/// <summary>
/// Species: Myotis sp. 1 ZZ-2009
/// NCBI TaxId: 631201
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myotis_sp_1_ZZ_2009 : Myotis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myotis sp. 1 ZZ-2009";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myotis_sp_1_ZZ_2009";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 631201;
}
