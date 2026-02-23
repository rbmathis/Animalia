namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

/// <summary>
/// Species: Cervidae sp.
/// NCBI TaxId: 163843
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cervidae_sp : Cervidae
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cervidae sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cervidae_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 163843;
}
