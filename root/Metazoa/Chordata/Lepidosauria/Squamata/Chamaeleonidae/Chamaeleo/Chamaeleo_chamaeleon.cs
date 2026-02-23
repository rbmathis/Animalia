namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Chamaeleo;

/// <summary>
/// Species: Chamaeleo chamaeleon
/// NCBI TaxId: 91907
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chamaeleo_chamaeleon : Chamaeleo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chamaeleo chamaeleon";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chamaeleo_chamaeleon";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 91907;
}
