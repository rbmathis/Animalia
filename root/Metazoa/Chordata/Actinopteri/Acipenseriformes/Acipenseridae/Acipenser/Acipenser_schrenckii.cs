namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Acipenser;

/// <summary>
/// Species: Acipenser schrenckii
/// NCBI TaxId: 111304
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acipenser_schrenckii : Acipenser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acipenser schrenckii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acipenser_schrenckii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 111304;
}
