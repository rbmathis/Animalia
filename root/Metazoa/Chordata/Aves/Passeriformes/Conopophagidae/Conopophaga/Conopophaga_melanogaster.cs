namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Conopophagidae.Conopophaga;

/// <summary>
/// Species: Conopophaga melanogaster
/// NCBI TaxId: 1118531
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Conopophaga_melanogaster : Conopophaga
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Conopophaga melanogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Conopophaga_melanogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1118531;
}
