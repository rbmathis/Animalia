namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus elegans
/// NCBI TaxId: 245683
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_elegans : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus elegans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_elegans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 245683;
}
