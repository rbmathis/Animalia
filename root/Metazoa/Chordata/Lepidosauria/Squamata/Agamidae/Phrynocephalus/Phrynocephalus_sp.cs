namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Phrynocephalus;

/// <summary>
/// Species: Phrynocephalus sp.
/// NCBI TaxId: 2517001
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynocephalus_sp : Phrynocephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynocephalus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynocephalus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2517001;
}
