namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Yungipicus;

/// <summary>
/// Species: Yungipicus temminckii
/// NCBI TaxId: 3150712
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Yungipicus_temminckii : Yungipicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Yungipicus temminckii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Yungipicus_temminckii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150712;
}
