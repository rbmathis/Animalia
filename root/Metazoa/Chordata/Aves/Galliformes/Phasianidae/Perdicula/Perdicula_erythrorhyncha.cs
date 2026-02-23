namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Perdicula;

/// <summary>
/// Species: Perdicula erythrorhyncha
/// NCBI TaxId: 1756207
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Perdicula_erythrorhyncha : Perdicula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Perdicula erythrorhyncha";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Perdicula_erythrorhyncha";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1756207;
}
