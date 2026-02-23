namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Scophthalmidae.Scophthalmus;

/// <summary>
/// Species: Scophthalmus environmental sample
/// NCBI TaxId: 1814144
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scophthalmus_environmental_sample : Scophthalmus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scophthalmus environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scophthalmus_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1814144;
}
