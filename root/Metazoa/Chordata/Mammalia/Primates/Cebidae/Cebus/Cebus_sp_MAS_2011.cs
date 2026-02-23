namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Cebus;

/// <summary>
/// Species: Cebus sp. MAS-2011
/// NCBI TaxId: 1090916
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cebus_sp_MAS_2011 : Cebus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cebus sp. MAS-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cebus_sp_MAS_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1090916;
}
