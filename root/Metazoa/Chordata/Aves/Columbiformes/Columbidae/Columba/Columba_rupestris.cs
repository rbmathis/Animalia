namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Columba;

/// <summary>
/// Species: Columba rupestris
/// NCBI TaxId: 126356
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Columba_rupestris : Columba
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Columba rupestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Columba_rupestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 126356;
}
