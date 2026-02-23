namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Puma;

/// <summary>
/// Species: Puma concolor
/// NCBI TaxId: 9696
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Puma_concolor : Puma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Puma concolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Puma_concolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9696;
}
