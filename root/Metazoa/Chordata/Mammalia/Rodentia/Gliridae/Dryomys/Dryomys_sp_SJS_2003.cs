namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Dryomys;

/// <summary>
/// Species: Dryomys sp. SJS-2003
/// NCBI TaxId: 243066
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dryomys_sp_SJS_2003 : Dryomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dryomys sp. SJS-2003";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dryomys_sp_SJS_2003";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 243066;
}
