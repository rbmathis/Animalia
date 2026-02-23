namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Saurida;

/// <summary>
/// Species: Saurida environmental sample
/// NCBI TaxId: 1563418
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Saurida_environmental_sample : Saurida
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Saurida environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Saurida_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1563418;
}
