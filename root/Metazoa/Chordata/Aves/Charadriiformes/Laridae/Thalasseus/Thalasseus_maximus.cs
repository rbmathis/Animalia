namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Thalasseus;

/// <summary>
/// Species: Thalasseus maximus
/// NCBI TaxId: 555356
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thalasseus_maximus : Thalasseus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thalasseus maximus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thalasseus_maximus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 555356;
}
