namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Pelecanidae.Pelecanus;

/// <summary>
/// Species: Pelecanus occidentalis
/// NCBI TaxId: 37043
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelecanus_occidentalis : Pelecanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelecanus occidentalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelecanus_occidentalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37043;
}
