namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus gurneyi
/// NCBI TaxId: 3150265
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_gurneyi : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus gurneyi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_gurneyi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150265;
}
