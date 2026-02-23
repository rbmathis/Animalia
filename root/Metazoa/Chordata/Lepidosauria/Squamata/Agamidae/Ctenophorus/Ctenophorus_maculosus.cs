namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Ctenophorus;

/// <summary>
/// Species: Ctenophorus maculosus
/// NCBI TaxId: 180913
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ctenophorus_maculosus : Ctenophorus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ctenophorus maculosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ctenophorus_maculosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 180913;
}
