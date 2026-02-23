namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Protopteridae.Protopterus;

/// <summary>
/// Species: Protopterus sp.
/// NCBI TaxId: 7887
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Protopterus_sp : Protopterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Protopterus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Protopterus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7887;
}
