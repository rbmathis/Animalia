namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Amiiformes.Amiidae.Amia;

/// <summary>
/// Species: Amia ocellicauda
/// NCBI TaxId: 2972642
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Amia_ocellicauda : Amia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Amia ocellicauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Amia_ocellicauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2972642;
}
