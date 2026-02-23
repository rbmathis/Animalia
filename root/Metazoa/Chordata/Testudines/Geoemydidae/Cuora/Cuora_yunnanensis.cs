namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cuora;

/// <summary>
/// Species: Cuora yunnanensis
/// NCBI TaxId: 176194
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuora_yunnanensis : Cuora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuora yunnanensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuora_yunnanensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 176194;
}
