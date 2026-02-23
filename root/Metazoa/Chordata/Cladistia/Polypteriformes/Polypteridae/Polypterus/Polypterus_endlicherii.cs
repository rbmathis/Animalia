namespace AnimalKingdom.root.Metazoa.Chordata.Cladistia.Polypteriformes.Polypteridae.Polypterus;

/// <summary>
/// Species: Polypterus endlicherii
/// NCBI TaxId: 348150
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Polypterus_endlicherii : Polypterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Polypterus endlicherii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Polypterus_endlicherii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 348150;
}
