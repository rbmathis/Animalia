namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Carpococcyx;

/// <summary>
/// Species: Carpococcyx radiceus
/// NCBI TaxId: 3055985
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Carpococcyx_radiceus : Carpococcyx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Carpococcyx radiceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Carpococcyx_radiceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3055985;
}
