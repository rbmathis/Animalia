namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Brachypteryx;

/// <summary>
/// Species: Brachypteryx cruralis
/// NCBI TaxId: 2518301
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brachypteryx_cruralis : Brachypteryx
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brachypteryx cruralis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brachypteryx_cruralis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2518301;
}
