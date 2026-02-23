namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Porphyrio;

/// <summary>
/// Species: Porphyrio porphyrio
/// NCBI TaxId: 171406
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Porphyrio_porphyrio : Porphyrio
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Porphyrio porphyrio";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Porphyrio_porphyrio";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 171406;
}
