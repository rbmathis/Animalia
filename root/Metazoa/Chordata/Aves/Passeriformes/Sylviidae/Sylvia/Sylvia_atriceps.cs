namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylvia;

/// <summary>
/// Species: Sylvia atriceps
/// NCBI TaxId: 3150600
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sylvia_atriceps : Sylvia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sylvia atriceps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sylvia_atriceps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150600;
}
