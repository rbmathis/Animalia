namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Meropidae.Nyctyornis;

/// <summary>
/// Species: Nyctyornis amictus
/// NCBI TaxId: 457351
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctyornis_amictus : Nyctyornis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctyornis amictus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctyornis_amictus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 457351;
}
