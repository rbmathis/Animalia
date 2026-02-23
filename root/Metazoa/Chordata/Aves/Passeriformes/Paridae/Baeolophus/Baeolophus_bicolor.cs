namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Baeolophus;

/// <summary>
/// Species: Baeolophus bicolor
/// NCBI TaxId: 88114
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Baeolophus_bicolor : Baeolophus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Baeolophus bicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Baeolophus_bicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 88114;
}
