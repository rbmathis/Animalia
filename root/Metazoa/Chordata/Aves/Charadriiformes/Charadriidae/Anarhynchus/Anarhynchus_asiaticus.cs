namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Anarhynchus;

/// <summary>
/// Species: Anarhynchus asiaticus
/// NCBI TaxId: 1630615
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anarhynchus_asiaticus : Anarhynchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anarhynchus asiaticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anarhynchus_asiaticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1630615;
}
