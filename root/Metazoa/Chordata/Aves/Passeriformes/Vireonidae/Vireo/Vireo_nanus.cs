namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae.Vireo;

/// <summary>
/// Species: Vireo nanus
/// NCBI TaxId: 1109103
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vireo_nanus : Vireo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vireo nanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vireo_nanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1109103;
}
