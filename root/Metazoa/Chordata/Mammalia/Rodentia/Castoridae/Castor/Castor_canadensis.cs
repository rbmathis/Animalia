namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Castoridae.Castor;

/// <summary>
/// Species: Castor canadensis
/// NCBI TaxId: 51338
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Castor_canadensis : Castor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Castor canadensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Castor_canadensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 51338;
}
