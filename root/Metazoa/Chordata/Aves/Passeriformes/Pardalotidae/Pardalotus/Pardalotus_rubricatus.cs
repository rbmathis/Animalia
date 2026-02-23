namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pardalotidae.Pardalotus;

/// <summary>
/// Species: Pardalotus rubricatus
/// NCBI TaxId: 722682
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pardalotus_rubricatus : Pardalotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pardalotus rubricatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pardalotus_rubricatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 722682;
}
