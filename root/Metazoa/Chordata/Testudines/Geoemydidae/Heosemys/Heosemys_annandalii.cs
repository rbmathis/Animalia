namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Heosemys;

/// <summary>
/// Species: Heosemys annandalii
/// NCBI TaxId: 260624
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Heosemys_annandalii : Heosemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Heosemys annandalii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Heosemys_annandalii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 260624;
}
