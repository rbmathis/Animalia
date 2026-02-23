namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus musculus musculus x Mus musculus molossinus
/// NCBI TaxId: 3004188
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_musculus_musculus_x_Mus_musculus_molossinus : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus musculus musculus x Mus musculus molossinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_musculus_musculus_x_Mus_musculus_molossinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3004188;
}
