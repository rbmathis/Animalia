namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Epinephelus;

/// <summary>
/// Species: Epinephelus sp.
/// NCBI TaxId: 3045277
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Epinephelus_sp : Epinephelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Epinephelus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Epinephelus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3045277;
}
