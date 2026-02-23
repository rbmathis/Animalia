namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Hyaenidae.Hyaena;

/// <summary>
/// Species: Hyaena hyaena
/// NCBI TaxId: 95912
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyaena_hyaena : Hyaena
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyaena hyaena";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyaena_hyaena";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 95912;
}
