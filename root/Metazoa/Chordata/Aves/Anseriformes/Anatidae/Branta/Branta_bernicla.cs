namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Branta;

/// <summary>
/// Species: Branta bernicla
/// NCBI TaxId: 184712
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Branta_bernicla : Branta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Branta bernicla";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Branta_bernicla";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 184712;
}
