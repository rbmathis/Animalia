namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Lophosaurus;

/// <summary>
/// Species: Lophosaurus boydii
/// NCBI TaxId: 206593
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lophosaurus_boydii : Lophosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lophosaurus boydii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lophosaurus_boydii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 206593;
}
