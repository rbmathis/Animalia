namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Tachyeres;

/// <summary>
/// Species: Tachyeres leucocephalus
/// NCBI TaxId: 658926
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tachyeres_leucocephalus : Tachyeres
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tachyeres leucocephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tachyeres_leucocephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 658926;
}
