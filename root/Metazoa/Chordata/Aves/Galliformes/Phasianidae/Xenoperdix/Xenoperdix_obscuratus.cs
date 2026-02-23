namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Xenoperdix;

/// <summary>
/// Species: Xenoperdix obscuratus
/// NCBI TaxId: 2759927
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenoperdix_obscuratus : Xenoperdix
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenoperdix obscuratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenoperdix_obscuratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2759927;
}
