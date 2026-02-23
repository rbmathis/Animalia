namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Thalasseus;

/// <summary>
/// Species: Thalasseus sandvicensis
/// NCBI TaxId: 126723
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thalasseus_sandvicensis : Thalasseus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thalasseus sandvicensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thalasseus_sandvicensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 126723;
}
