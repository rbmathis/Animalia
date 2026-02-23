namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Syngnathus;

/// <summary>
/// Species: Syngnathus carinatus
/// NCBI TaxId: 2842185
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Syngnathus_carinatus : Syngnathus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Syngnathus carinatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Syngnathus_carinatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2842185;
}
