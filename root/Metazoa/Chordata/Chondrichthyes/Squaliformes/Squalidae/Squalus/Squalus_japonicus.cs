namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus japonicus
/// NCBI TaxId: 42864
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_japonicus : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus japonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_japonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 42864;
}
