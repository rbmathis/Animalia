namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Megophrys;

/// <summary>
/// Species: Megophrys platyparietus
/// NCBI TaxId: 3135199
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Megophrys_platyparietus : Megophrys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Megophrys platyparietus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Megophrys_platyparietus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3135199;
}
