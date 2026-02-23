namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Trachyphonus;

/// <summary>
/// Species: Trachyphonus margaritatus
/// NCBI TaxId: 1811345
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachyphonus_margaritatus : Trachyphonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachyphonus margaritatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachyphonus_margaritatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1811345;
}
