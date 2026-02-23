namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Proteidae.Proteus;

/// <summary>
/// Species: Proteus anguinus
/// NCBI TaxId: 221568
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Proteus_anguinus : Proteus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Proteus anguinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Proteus_anguinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 221568;
}
