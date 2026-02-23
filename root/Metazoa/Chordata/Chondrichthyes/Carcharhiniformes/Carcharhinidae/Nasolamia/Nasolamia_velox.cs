namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Nasolamia;

/// <summary>
/// Species: Nasolamia velox
/// NCBI TaxId: 671162
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nasolamia_velox : Nasolamia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nasolamia velox";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nasolamia_velox";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 671162;
}
