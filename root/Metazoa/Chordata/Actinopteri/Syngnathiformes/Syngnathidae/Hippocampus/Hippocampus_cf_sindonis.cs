namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Hippocampus;

/// <summary>
/// Species: Hippocampus cf. sindonis
/// NCBI TaxId: 103718
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hippocampus_cf_sindonis : Hippocampus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hippocampus cf. sindonis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hippocampus_cf_sindonis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 103718;
}
