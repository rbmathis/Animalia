namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Delphinidae.Orcinus;

/// <summary>
/// Species: Orcinus orca
/// NCBI TaxId: 9733
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Orcinus_orca : Orcinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Orcinus orca";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Orcinus_orca";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9733;
}
