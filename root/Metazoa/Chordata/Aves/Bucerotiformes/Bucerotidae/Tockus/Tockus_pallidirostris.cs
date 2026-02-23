namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Tockus;

/// <summary>
/// Species: Tockus pallidirostris
/// NCBI TaxId: 3150087
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tockus_pallidirostris : Tockus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tockus pallidirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tockus_pallidirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150087;
}
