namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Oenanthe;

/// <summary>
/// Species: Oenanthe albifrons
/// NCBI TaxId: 3150240
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oenanthe_albifrons : Oenanthe
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oenanthe albifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oenanthe_albifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150240;
}
