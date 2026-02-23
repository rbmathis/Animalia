namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cyanocitta;

/// <summary>
/// Species: Cyanocitta stelleri
/// NCBI TaxId: 114083
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyanocitta_stelleri : Cyanocitta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyanocitta stelleri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyanocitta_stelleri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 114083;
}
