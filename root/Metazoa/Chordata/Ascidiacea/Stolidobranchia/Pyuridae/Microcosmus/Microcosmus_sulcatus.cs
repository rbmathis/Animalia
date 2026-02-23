namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Microcosmus;

/// <summary>
/// Species: Microcosmus sulcatus
/// NCBI TaxId: 341086
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microcosmus_sulcatus : Microcosmus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microcosmus sulcatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microcosmus_sulcatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 341086;
}
