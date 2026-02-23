namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Ostracion;

/// <summary>
/// Species: Ostracion meleagris
/// NCBI TaxId: 342444
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ostracion_meleagris : Ostracion
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ostracion meleagris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ostracion_meleagris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 342444;
}
