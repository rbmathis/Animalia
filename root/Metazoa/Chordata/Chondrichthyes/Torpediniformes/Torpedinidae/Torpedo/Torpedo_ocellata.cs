namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae.Torpedo;

/// <summary>
/// Species: Torpedo ocellata
/// NCBI TaxId: 30481
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Torpedo_ocellata : Torpedo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Torpedo ocellata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Torpedo_ocellata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30481;
}
