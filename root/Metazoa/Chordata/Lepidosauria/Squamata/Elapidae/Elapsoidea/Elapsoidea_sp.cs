namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Elapsoidea;

/// <summary>
/// Species: Elapsoidea sp.
/// NCBI TaxId: 2993752
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elapsoidea_sp : Elapsoidea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elapsoidea sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elapsoidea_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2993752;
}
