namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Odocoileus;

/// <summary>
/// Species: Odocoileus sp.
/// NCBI TaxId: 39410
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Odocoileus_sp : Odocoileus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Odocoileus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Odocoileus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 39410;
}
