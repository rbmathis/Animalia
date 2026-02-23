namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Accipiter;

/// <summary>
/// Species: Accipiter novaehollandiae
/// NCBI TaxId: 387801
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Accipiter_novaehollandiae : Accipiter
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Accipiter novaehollandiae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Accipiter_novaehollandiae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 387801;
}
