namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rhaebo;

/// <summary>
/// Species: Rhaebo haematiticus
/// NCBI TaxId: 30333
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhaebo_haematiticus : Rhaebo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhaebo haematiticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhaebo_haematiticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30333;
}
