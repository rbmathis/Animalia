namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Epinephelus;

/// <summary>
/// Species: Epinephelus japonicus
/// NCBI TaxId: 2803755
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Epinephelus_japonicus : Epinephelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Epinephelus japonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Epinephelus_japonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2803755;
}
