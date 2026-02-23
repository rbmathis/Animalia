namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Alligator;

/// <summary>
/// Species: Alligator sinensis
/// NCBI TaxId: 38654
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alligator_sinensis : Alligator
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alligator sinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alligator_sinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 38654;
}
