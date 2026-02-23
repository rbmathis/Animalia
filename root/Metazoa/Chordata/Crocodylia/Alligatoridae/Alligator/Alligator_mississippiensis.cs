namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Alligatoridae.Alligator;

/// <summary>
/// Species: Alligator mississippiensis
/// NCBI TaxId: 8496
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alligator_mississippiensis : Alligator
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alligator mississippiensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alligator_mississippiensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8496;
}
