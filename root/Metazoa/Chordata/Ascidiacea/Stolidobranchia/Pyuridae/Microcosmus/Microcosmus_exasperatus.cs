namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Microcosmus;

/// <summary>
/// Species: Microcosmus exasperatus
/// NCBI TaxId: 1789648
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microcosmus_exasperatus : Microcosmus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microcosmus exasperatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microcosmus_exasperatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1789648;
}
