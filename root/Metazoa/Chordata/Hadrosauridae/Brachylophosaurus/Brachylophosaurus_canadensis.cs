namespace AnimalKingdom.root.Metazoa.Chordata.Hadrosauridae.Brachylophosaurus;

/// <summary>
/// Species: Brachylophosaurus canadensis
/// NCBI TaxId: 643745
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brachylophosaurus_canadensis : Brachylophosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brachylophosaurus canadensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brachylophosaurus_canadensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 643745;
}
