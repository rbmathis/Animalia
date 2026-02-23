namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tatera;

/// <summary>
/// Species: Tatera sp. IIB-2009a
/// NCBI TaxId: 644972
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tatera_sp_IIB_2009a : Tatera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tatera sp. IIB-2009a";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tatera_sp_IIB_2009a";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 644972;
}
