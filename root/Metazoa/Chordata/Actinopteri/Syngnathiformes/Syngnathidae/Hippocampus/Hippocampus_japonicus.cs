namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Hippocampus;

/// <summary>
/// Species: Hippocampus japonicus
/// NCBI TaxId: 103716
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hippocampus_japonicus : Hippocampus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hippocampus japonicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hippocampus_japonicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 103716;
}
