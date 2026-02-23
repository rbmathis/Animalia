namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus sp. TK0000013
/// NCBI TaxId: 3028011
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_sp_TK0000013 : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus sp. TK0000013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_sp_TK0000013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3028011;
}
