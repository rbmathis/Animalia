namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Oenanthe;

/// <summary>
/// Species: Oenanthe monacha
/// NCBI TaxId: 391701
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oenanthe_monacha : Oenanthe
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oenanthe monacha";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oenanthe_monacha";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 391701;
}
