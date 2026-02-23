namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cyanocitta;

/// <summary>
/// Species: Cyanocitta cristata
/// NCBI TaxId: 28727
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyanocitta_cristata : Cyanocitta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyanocitta cristata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyanocitta_cristata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 28727;
}
