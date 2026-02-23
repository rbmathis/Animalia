namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zeidae.Zeus;

/// <summary>
/// Species: Zeus japonicus
/// NCBI TaxId: 1297550
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Zeus_japonicus : Zeus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Zeus japonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Zeus_japonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1297550;
}
