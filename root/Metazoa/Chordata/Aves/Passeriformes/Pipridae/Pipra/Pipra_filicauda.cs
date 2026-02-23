namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Pipra;

/// <summary>
/// Species: Pipra filicauda
/// NCBI TaxId: 649802
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pipra_filicauda : Pipra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pipra filicauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pipra_filicauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 649802;
}
