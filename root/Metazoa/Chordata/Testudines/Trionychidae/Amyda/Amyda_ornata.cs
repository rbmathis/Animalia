namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Amyda;

/// <summary>
/// Species: Amyda ornata
/// NCBI TaxId: 1541068
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amyda_ornata : Amyda
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amyda ornata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amyda_ornata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1541068;
}
