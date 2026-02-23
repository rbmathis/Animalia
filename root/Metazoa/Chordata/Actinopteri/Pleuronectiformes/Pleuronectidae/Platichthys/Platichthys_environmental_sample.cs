namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Platichthys;

/// <summary>
/// Species: Platichthys environmental sample
/// NCBI TaxId: 1814140
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platichthys_environmental_sample : Platichthys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platichthys environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platichthys_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1814140;
}
