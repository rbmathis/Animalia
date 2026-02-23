namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Epinephelus;

/// <summary>
/// Species: Epinephelus malabaricus
/// NCBI TaxId: 162300
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Epinephelus_malabaricus : Epinephelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Epinephelus malabaricus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Epinephelus_malabaricus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 162300;
}
