namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Chamaeleo;

/// <summary>
/// Species: Chamaeleo zeylanicus
/// NCBI TaxId: 420384
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chamaeleo_zeylanicus : Chamaeleo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chamaeleo zeylanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chamaeleo_zeylanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 420384;
}
