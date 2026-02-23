namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Theropithecus;

/// <summary>
/// Species: Theropithecus gelada
/// NCBI TaxId: 9565
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Theropithecus_gelada : Theropithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Theropithecus gelada";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Theropithecus_gelada";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9565;
}
