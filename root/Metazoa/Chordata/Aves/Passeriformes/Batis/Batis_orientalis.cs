namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Batis;

/// <summary>
/// Species: Batis orientalis
/// NCBI TaxId: 392391
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Batis_orientalis : Batis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Batis orientalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Batis_orientalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 392391;
}
