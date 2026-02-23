namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Galloperdix;

/// <summary>
/// Species: Galloperdix spadicea
/// NCBI TaxId: 1507505
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Galloperdix_spadicea : Galloperdix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Galloperdix spadicea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Galloperdix_spadicea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1507505;
}
