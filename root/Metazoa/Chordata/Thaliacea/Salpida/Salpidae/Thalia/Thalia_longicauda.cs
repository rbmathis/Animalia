namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Thalia;

/// <summary>
/// Species: Thalia longicauda
/// NCBI TaxId: 1408229
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thalia_longicauda : Thalia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thalia longicauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thalia_longicauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1408229;
}
