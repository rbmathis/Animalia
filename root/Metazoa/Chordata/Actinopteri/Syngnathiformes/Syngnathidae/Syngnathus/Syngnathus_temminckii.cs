namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Syngnathus;

/// <summary>
/// Species: Syngnathus temminckii
/// NCBI TaxId: 240697
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Syngnathus_temminckii : Syngnathus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Syngnathus temminckii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Syngnathus_temminckii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 240697;
}
