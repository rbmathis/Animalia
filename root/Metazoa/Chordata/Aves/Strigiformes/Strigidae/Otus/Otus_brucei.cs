namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus brucei
/// NCBI TaxId: 126814
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_brucei : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus brucei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_brucei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 126814;
}
