namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Thalasseus;

/// <summary>
/// Species: Thalasseus bengalensis
/// NCBI TaxId: 2705045
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thalasseus_bengalensis : Thalasseus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thalasseus bengalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thalasseus_bengalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2705045;
}
