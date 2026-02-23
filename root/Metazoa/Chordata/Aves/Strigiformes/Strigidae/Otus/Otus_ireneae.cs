namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus ireneae
/// NCBI TaxId: 543865
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_ireneae : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus ireneae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_ireneae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 543865;
}
