namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Lonchura;

/// <summary>
/// Species: Lonchura leucogastroides
/// NCBI TaxId: 414890
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lonchura_leucogastroides : Lonchura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lonchura leucogastroides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lonchura_leucogastroides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 414890;
}
