namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Cervus;

/// <summary>
/// Species: Cervus albirostris
/// NCBI TaxId: 1088058
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cervus_albirostris : Cervus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cervus albirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cervus_albirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1088058;
}
