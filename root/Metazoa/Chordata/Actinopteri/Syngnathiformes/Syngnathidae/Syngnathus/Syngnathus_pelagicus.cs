namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Syngnathus;

/// <summary>
/// Species: Syngnathus pelagicus
/// NCBI TaxId: 1073239
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Syngnathus_pelagicus : Syngnathus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Syngnathus pelagicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Syngnathus_pelagicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1073239;
}
