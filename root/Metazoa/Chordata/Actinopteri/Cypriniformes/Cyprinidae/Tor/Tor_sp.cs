namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Tor;

/// <summary>
/// Species: Tor sp.
/// NCBI TaxId: 3434543
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tor_sp : Tor
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tor sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tor_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3434543;
}
