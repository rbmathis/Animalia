namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Lonchura;

/// <summary>
/// Species: Lonchura oryzivora
/// NCBI TaxId: 2820150
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lonchura_oryzivora : Lonchura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lonchura oryzivora";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lonchura_oryzivora";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2820150;
}
