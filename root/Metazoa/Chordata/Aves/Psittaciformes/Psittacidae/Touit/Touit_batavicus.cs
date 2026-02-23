namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Touit;

/// <summary>
/// Species: Touit batavicus
/// NCBI TaxId: 504089
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Touit_batavicus : Touit
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Touit batavicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Touit_batavicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 504089;
}
