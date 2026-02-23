namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leiopelmatidae.Leiopelma;

/// <summary>
/// Species: Leiopelma hamiltoni
/// NCBI TaxId: 43508
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leiopelma_hamiltoni : Leiopelma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leiopelma hamiltoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leiopelma_hamiltoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43508;
}
