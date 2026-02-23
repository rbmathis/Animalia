namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Acomys;

/// <summary>
/// Species: Acomys sp. B (cahirinus group)
/// NCBI TaxId: 2496224
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acomys_sp_B_cahirinus_group : Acomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acomys sp. B (cahirinus group)";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acomys_sp_B_cahirinus_group";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2496224;
}
