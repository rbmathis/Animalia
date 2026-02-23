namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhipiduridae.Rhipidura;

/// <summary>
/// Species: Rhipidura albicollis
/// NCBI TaxId: 107228
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhipidura_albicollis : Rhipidura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhipidura albicollis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhipidura_albicollis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 107228;
}
