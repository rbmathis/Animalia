namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Cercopithecus;

/// <summary>
/// Species: Cercopithecus petaurista
/// NCBI TaxId: 100487
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cercopithecus_petaurista : Cercopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cercopithecus petaurista";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cercopithecus_petaurista";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100487;
}
