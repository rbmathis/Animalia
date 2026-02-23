namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cyanocitta;

/// <summary>
/// Species: Cyanocitta sp.
/// NCBI TaxId: 2878422
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyanocitta_sp : Cyanocitta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyanocitta sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyanocitta_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2878422;
}
