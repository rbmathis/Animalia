namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pseudorectes;

/// <summary>
/// Species: Pseudorectes ferrugineus
/// NCBI TaxId: 1743254
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudorectes_ferrugineus : Pseudorectes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudorectes ferrugineus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudorectes_ferrugineus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1743254;
}
