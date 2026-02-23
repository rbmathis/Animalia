namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Picus;

/// <summary>
/// Species: Picus puniceus
/// NCBI TaxId: 535306
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Picus_puniceus : Picus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Picus puniceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Picus_puniceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 535306;
}
