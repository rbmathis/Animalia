namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae.Phalanger;

/// <summary>
/// Species: Phalanger maculatus
/// NCBI TaxId: 88213
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phalanger_maculatus : Phalanger
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phalanger maculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phalanger_maculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 88213;
}
