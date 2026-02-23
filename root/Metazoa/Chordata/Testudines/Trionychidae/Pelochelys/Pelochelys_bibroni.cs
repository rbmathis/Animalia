namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Pelochelys;

/// <summary>
/// Species: Pelochelys bibroni
/// NCBI TaxId: 171792
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelochelys_bibroni : Pelochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelochelys bibroni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelochelys_bibroni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 171792;
}
