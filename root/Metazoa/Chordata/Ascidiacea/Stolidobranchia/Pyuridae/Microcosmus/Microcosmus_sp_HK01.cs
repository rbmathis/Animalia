namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Microcosmus;

/// <summary>
/// Species: Microcosmus sp. HK01
/// NCBI TaxId: 3140100
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microcosmus_sp_HK01 : Microcosmus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microcosmus sp. HK01";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microcosmus_sp_HK01";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3140100;
}
