namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Mulleripicus;

/// <summary>
/// Species: Mulleripicus fulvus
/// NCBI TaxId: 1517774
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mulleripicus_fulvus : Mulleripicus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mulleripicus fulvus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mulleripicus_fulvus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1517774;
}
