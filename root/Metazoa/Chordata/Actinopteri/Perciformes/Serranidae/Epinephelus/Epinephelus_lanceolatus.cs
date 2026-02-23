namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Epinephelus;

/// <summary>
/// Species: Epinephelus lanceolatus
/// NCBI TaxId: 310571
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Epinephelus_lanceolatus : Epinephelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Epinephelus lanceolatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Epinephelus_lanceolatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 310571;
}
