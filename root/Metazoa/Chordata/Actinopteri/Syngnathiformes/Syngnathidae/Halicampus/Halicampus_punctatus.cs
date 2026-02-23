namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Halicampus;

/// <summary>
/// Species: Halicampus punctatus
/// NCBI TaxId: 2842177
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Halicampus_punctatus : Halicampus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Halicampus punctatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Halicampus_punctatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2842177;
}
