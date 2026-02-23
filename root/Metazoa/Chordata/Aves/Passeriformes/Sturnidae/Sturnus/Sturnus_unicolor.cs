namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Sturnus;

/// <summary>
/// Species: Sturnus unicolor
/// NCBI TaxId: 381112
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sturnus_unicolor : Sturnus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sturnus unicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sturnus_unicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 381112;
}
