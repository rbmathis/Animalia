namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Chitra;

/// <summary>
/// Species: Chitra indica
/// NCBI TaxId: 171798
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chitra_indica : Chitra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chitra indica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chitra_indica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 171798;
}
