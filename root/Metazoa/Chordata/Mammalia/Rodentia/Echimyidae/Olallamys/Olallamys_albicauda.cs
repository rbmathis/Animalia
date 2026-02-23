namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Olallamys;

/// <summary>
/// Species: Olallamys albicauda
/// NCBI TaxId: 1400528
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Olallamys_albicauda : Olallamys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Olallamys albicauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Olallamys_albicauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1400528;
}
