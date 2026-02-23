namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Chamaesaura;

/// <summary>
/// Species: Chamaesaura anguina
/// NCBI TaxId: 126628
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chamaesaura_anguina : Chamaesaura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chamaesaura anguina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chamaesaura_anguina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 126628;
}
