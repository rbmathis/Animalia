namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Gactornis;

/// <summary>
/// Species: Gactornis enarratus
/// NCBI TaxId: 1854004
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gactornis_enarratus : Gactornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gactornis enarratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gactornis_enarratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1854004;
}
