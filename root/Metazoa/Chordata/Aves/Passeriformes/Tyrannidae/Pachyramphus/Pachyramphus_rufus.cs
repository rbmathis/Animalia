namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Pachyramphus;

/// <summary>
/// Species: Pachyramphus rufus
/// NCBI TaxId: 369606
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachyramphus_rufus : Pachyramphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachyramphus rufus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachyramphus_rufus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 369606;
}
