namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Gymnophthalmus;

/// <summary>
/// Species: Gymnophthalmus speciosus
/// NCBI TaxId: 88866
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gymnophthalmus_speciosus : Gymnophthalmus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gymnophthalmus speciosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gymnophthalmus_speciosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 88866;
}
