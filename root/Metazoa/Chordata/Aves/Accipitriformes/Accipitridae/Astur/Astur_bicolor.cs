namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Astur;

/// <summary>
/// Species: Astur bicolor
/// NCBI TaxId: 321116
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Astur_bicolor : Astur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Astur bicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Astur_bicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 321116;
}
