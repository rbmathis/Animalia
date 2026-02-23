namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Hydrosaurus;

/// <summary>
/// Species: Hydrosaurus cf. amboinensis
/// NCBI TaxId: 645700
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hydrosaurus_cf_amboinensis : Hydrosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hydrosaurus cf. amboinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hydrosaurus_cf_amboinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 645700;
}
