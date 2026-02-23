namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Ramphocaenus;

/// <summary>
/// Species: Ramphocaenus melanurus
/// NCBI TaxId: 592666
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ramphocaenus_melanurus : Ramphocaenus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ramphocaenus melanurus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ramphocaenus_melanurus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 592666;
}
