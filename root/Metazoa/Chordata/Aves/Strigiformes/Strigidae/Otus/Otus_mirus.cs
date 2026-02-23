namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus mirus
/// NCBI TaxId: 56277
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_mirus : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus mirus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_mirus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56277;
}
