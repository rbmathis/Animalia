namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.Scomber;

/// <summary>
/// Species: Scomber scombrus
/// NCBI TaxId: 13677
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scomber_scombrus : Scomber
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scomber scombrus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scomber_scombrus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13677;
}
