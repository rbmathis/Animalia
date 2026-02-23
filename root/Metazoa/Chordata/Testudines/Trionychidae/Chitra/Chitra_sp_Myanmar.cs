namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Chitra;

/// <summary>
/// Species: Chitra sp. Myanmar
/// NCBI TaxId: 171800
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chitra_sp_Myanmar : Chitra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chitra sp. Myanmar";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chitra_sp_Myanmar";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 171800;
}
