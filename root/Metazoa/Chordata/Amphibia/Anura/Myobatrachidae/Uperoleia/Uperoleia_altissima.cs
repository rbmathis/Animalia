namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Uperoleia;

/// <summary>
/// Species: Uperoleia altissima
/// NCBI TaxId: 1104365
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Uperoleia_altissima : Uperoleia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Uperoleia altissima";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Uperoleia_altissima";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1104365;
}
