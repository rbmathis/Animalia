namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Pusa;

/// <summary>
/// Species: Pusa hispida
/// NCBI TaxId: 9718
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pusa_hispida : Pusa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pusa hispida";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pusa_hispida";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9718;
}
