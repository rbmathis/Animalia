namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Odocoileus;

/// <summary>
/// Species: Odocoileus pandora
/// NCBI TaxId: 1380314
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Odocoileus_pandora : Odocoileus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Odocoileus pandora";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Odocoileus_pandora";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1380314;
}
