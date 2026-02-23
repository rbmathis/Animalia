namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Phalotris;

/// <summary>
/// Species: Phalotris lemniscatus
/// NCBI TaxId: 666098
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phalotris_lemniscatus : Phalotris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phalotris lemniscatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phalotris_lemniscatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 666098;
}
