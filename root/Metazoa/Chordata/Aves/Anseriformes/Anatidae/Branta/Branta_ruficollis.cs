namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Branta;

/// <summary>
/// Species: Branta ruficollis
/// NCBI TaxId: 184715
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Branta_ruficollis : Branta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Branta ruficollis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Branta_ruficollis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 184715;
}
