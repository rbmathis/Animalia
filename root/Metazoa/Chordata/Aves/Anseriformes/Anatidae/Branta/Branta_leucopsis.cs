namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Branta;

/// <summary>
/// Species: Branta leucopsis
/// NCBI TaxId: 184711
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Branta_leucopsis : Branta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Branta leucopsis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Branta_leucopsis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 184711;
}
