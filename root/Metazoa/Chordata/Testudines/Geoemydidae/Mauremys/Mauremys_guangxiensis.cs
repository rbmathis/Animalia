namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Mauremys;

/// <summary>
/// Species: Mauremys guangxiensis
/// NCBI TaxId: 1234617
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mauremys_guangxiensis : Mauremys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mauremys guangxiensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mauremys_guangxiensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1234617;
}
