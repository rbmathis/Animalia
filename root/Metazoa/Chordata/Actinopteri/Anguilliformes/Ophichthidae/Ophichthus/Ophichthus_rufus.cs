namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Ophichthus;

/// <summary>
/// Species: Ophichthus rufus
/// NCBI TaxId: 2603885
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ophichthus_rufus : Ophichthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ophichthus rufus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ophichthus_rufus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2603885;
}
