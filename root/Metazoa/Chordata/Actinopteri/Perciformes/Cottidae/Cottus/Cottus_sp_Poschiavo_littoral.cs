namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Cottus;

/// <summary>
/// Species: Cottus sp. Poschiavo littoral
/// NCBI TaxId: 2962548
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cottus_sp_Poschiavo_littoral : Cottus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cottus sp. Poschiavo littoral";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cottus_sp_Poschiavo_littoral";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2962548;
}
