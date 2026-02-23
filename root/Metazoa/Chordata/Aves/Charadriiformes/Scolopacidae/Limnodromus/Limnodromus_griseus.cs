namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Limnodromus;

/// <summary>
/// Species: Limnodromus griseus
/// NCBI TaxId: 279949
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Limnodromus_griseus : Limnodromus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Limnodromus griseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Limnodromus_griseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 279949;
}
