namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelus;

/// <summary>
/// Species: Chelus fimbriata
/// NCBI TaxId: 44495
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelus_fimbriata : Chelus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelus fimbriata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelus_fimbriata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44495;
}
