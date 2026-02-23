namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Spizaetus;

/// <summary>
/// Species: Spizaetus tyrannus
/// NCBI TaxId: 252798
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spizaetus_tyrannus : Spizaetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spizaetus tyrannus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spizaetus_tyrannus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 252798;
}
