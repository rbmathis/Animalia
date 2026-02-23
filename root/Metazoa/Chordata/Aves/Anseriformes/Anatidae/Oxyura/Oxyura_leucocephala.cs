namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Oxyura;

/// <summary>
/// Species: Oxyura leucocephala
/// NCBI TaxId: 90703
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oxyura_leucocephala : Oxyura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oxyura leucocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oxyura_leucocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 90703;
}
