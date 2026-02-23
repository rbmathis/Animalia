namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Pelecanidae.Pelecanus;

/// <summary>
/// Species: Pelecanus erythrorhynchos
/// NCBI TaxId: 33618
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelecanus_erythrorhynchos : Pelecanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelecanus erythrorhynchos";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelecanus_erythrorhynchos";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33618;
}
