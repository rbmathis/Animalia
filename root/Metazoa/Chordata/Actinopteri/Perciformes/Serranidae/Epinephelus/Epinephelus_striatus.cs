namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Epinephelus;

/// <summary>
/// Species: Epinephelus striatus
/// NCBI TaxId: 160727
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Epinephelus_striatus : Epinephelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Epinephelus striatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Epinephelus_striatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 160727;
}
