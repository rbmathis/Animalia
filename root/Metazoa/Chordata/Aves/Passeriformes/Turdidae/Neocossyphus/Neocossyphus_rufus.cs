namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Neocossyphus;

/// <summary>
/// Species: Neocossyphus rufus
/// NCBI TaxId: 127935
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neocossyphus_rufus : Neocossyphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neocossyphus rufus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neocossyphus_rufus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 127935;
}
