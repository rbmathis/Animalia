namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhipiduridae.Rhipidura;

/// <summary>
/// Species: Rhipidura javanica
/// NCBI TaxId: 512575
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhipidura_javanica : Rhipidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhipidura javanica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhipidura_javanica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 512575;
}
