namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Cophosaurus;

/// <summary>
/// Species: Cophosaurus sp.
/// NCBI TaxId: 3452249
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cophosaurus_sp : Cophosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cophosaurus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cophosaurus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3452249;
}
