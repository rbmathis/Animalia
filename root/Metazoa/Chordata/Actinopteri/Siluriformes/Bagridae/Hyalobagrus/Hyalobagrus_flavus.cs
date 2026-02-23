namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Hyalobagrus;

/// <summary>
/// Species: Hyalobagrus flavus
/// NCBI TaxId: 337769
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyalobagrus_flavus : Hyalobagrus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyalobagrus flavus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyalobagrus_flavus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 337769;
}
