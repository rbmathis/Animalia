namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Corvus;

/// <summary>
/// Species: Corvus corax
/// NCBI TaxId: 56781
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Corvus_corax : Corvus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Corvus corax";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Corvus_corax";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56781;
}
