namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Ctenophorus;

/// <summary>
/// Species: Ctenophorus maculatus
/// NCBI TaxId: 180912
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ctenophorus_maculatus : Ctenophorus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ctenophorus maculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ctenophorus_maculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 180912;
}
