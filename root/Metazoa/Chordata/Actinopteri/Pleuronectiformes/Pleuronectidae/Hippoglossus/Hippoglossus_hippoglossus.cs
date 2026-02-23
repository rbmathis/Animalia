namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Hippoglossus;

/// <summary>
/// Species: Hippoglossus hippoglossus
/// NCBI TaxId: 8267
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hippoglossus_hippoglossus : Hippoglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hippoglossus hippoglossus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hippoglossus_hippoglossus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8267;
}
