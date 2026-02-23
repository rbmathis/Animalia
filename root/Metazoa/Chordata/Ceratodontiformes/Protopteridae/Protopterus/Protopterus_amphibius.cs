namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Protopteridae.Protopterus;

/// <summary>
/// Species: Protopterus amphibius
/// NCBI TaxId: 286788
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Protopterus_amphibius : Protopterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Protopterus amphibius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Protopterus_amphibius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 286788;
}
