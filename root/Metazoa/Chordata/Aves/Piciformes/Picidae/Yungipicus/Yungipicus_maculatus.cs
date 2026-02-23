namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Yungipicus;

/// <summary>
/// Species: Yungipicus maculatus
/// NCBI TaxId: 1118543
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Yungipicus_maculatus : Yungipicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Yungipicus maculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Yungipicus_maculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1118543;
}
