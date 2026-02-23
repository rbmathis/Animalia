namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Pleuronectidae.Platichthys;

/// <summary>
/// Species: Platichthys flesus
/// NCBI TaxId: 8260
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platichthys_flesus : Platichthys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platichthys flesus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platichthys_flesus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8260;
}
