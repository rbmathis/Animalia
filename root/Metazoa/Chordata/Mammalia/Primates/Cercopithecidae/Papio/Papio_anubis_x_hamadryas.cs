namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Papio;

/// <summary>
/// Species: Papio anubis x hamadryas
/// NCBI TaxId: 1560552
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Papio_anubis_x_hamadryas : Papio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Papio anubis x hamadryas";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Papio_anubis_x_hamadryas";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1560552;
}
