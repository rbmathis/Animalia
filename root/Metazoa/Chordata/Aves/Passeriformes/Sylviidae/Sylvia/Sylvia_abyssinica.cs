namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylvia;

/// <summary>
/// Species: Sylvia abyssinica
/// NCBI TaxId: 528194
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sylvia_abyssinica : Sylvia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sylvia abyssinica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sylvia_abyssinica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 528194;
}
