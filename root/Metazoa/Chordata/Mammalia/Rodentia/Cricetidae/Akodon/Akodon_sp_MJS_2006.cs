namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Akodon;

/// <summary>
/// Species: Akodon sp. MJS-2006
/// NCBI TaxId: 389470
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Akodon_sp_MJS_2006 : Akodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Akodon sp. MJS-2006";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Akodon_sp_MJS_2006";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 389470;
}
