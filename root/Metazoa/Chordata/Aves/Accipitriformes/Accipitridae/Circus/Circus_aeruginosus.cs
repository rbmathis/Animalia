namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Circus;

/// <summary>
/// Species: Circus aeruginosus
/// NCBI TaxId: 8964
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Circus_aeruginosus : Circus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Circus aeruginosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Circus_aeruginosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8964;
}
