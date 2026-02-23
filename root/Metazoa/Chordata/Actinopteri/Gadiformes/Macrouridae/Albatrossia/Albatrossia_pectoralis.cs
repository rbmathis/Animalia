namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Albatrossia;

/// <summary>
/// Species: Albatrossia pectoralis
/// NCBI TaxId: 83392
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Albatrossia_pectoralis : Albatrossia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Albatrossia pectoralis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Albatrossia_pectoralis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 83392;
}
