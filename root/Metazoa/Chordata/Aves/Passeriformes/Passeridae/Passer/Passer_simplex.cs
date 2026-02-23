namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Passer;

/// <summary>
/// Species: Passer simplex
/// NCBI TaxId: 150919
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Passer_simplex : Passer
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Passer simplex";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Passer_simplex";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 150919;
}
