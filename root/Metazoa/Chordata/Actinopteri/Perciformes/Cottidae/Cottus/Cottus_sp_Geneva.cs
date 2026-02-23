namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Cottus;

/// <summary>
/// Species: Cottus sp. Geneva
/// NCBI TaxId: 2861219
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cottus_sp_Geneva : Cottus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cottus sp. Geneva";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cottus_sp_Geneva";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2861219;
}
