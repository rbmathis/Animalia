namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Lophosaurus;

/// <summary>
/// Species: Lophosaurus dilophus
/// NCBI TaxId: 118208
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lophosaurus_dilophus : Lophosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lophosaurus dilophus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lophosaurus_dilophus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 118208;
}
