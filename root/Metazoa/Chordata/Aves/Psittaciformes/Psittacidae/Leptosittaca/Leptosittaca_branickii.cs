namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Leptosittaca;

/// <summary>
/// Species: Leptosittaca branickii
/// NCBI TaxId: 503990
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptosittaca_branickii : Leptosittaca
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptosittaca branickii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptosittaca_branickii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 503990;
}
