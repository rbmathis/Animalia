namespace AnimalKingdom.root.Metazoa.Chordata.Cladistia.Polypteriformes.Polypteridae.Polypterus;

/// <summary>
/// Species: Polypterus senegalus
/// NCBI TaxId: 55291
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Polypterus_senegalus : Polypterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Polypterus senegalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Polypterus_senegalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 55291;
}
