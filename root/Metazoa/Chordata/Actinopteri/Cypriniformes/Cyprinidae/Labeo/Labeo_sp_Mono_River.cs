namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeo;

/// <summary>
/// Species: Labeo sp. Mono River
/// NCBI TaxId: 2056620
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Labeo_sp_Mono_River : Labeo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Labeo sp. Mono River";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Labeo_sp_Mono_River";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2056620;
}
