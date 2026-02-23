namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Cottus;

/// <summary>
/// Species: Cottus sp. Adriatic-Ticino
/// NCBI TaxId: 2962539
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cottus_sp_Adriatic_Ticino : Cottus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cottus sp. Adriatic-Ticino";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cottus_sp_Adriatic_Ticino";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2962539;
}
