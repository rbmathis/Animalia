namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Limnodromus;

/// <summary>
/// Species: Limnodromus scolopaceus
/// NCBI TaxId: 161678
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Limnodromus_scolopaceus : Limnodromus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Limnodromus scolopaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Limnodromus_scolopaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 161678;
}
