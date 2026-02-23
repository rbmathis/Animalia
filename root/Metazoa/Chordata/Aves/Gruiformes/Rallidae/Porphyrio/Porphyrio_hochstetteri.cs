namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Porphyrio;

/// <summary>
/// Species: Porphyrio hochstetteri
/// NCBI TaxId: 439704
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Porphyrio_hochstetteri : Porphyrio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Porphyrio hochstetteri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Porphyrio_hochstetteri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 439704;
}
