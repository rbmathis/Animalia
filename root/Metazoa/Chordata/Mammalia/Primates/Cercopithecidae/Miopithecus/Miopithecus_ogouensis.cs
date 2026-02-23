namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Miopithecus;

/// <summary>
/// Species: Miopithecus ogouensis
/// NCBI TaxId: 100488
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Miopithecus_ogouensis : Miopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Miopithecus ogouensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Miopithecus_ogouensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 100488;
}
