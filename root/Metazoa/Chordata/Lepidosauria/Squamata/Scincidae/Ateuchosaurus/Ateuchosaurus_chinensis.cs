namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ateuchosaurus;

/// <summary>
/// Species: Ateuchosaurus chinensis
/// NCBI TaxId: 2597157
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ateuchosaurus_chinensis : Ateuchosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ateuchosaurus chinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ateuchosaurus_chinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2597157;
}
