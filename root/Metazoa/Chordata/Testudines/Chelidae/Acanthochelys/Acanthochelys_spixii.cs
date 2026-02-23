namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Acanthochelys;

/// <summary>
/// Species: Acanthochelys spixii
/// NCBI TaxId: 241403
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acanthochelys_spixii : Acanthochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acanthochelys spixii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acanthochelys_spixii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 241403;
}
