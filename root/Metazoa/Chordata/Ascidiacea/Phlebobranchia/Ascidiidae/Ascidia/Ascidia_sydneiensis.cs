namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Ascidiidae.Ascidia;

/// <summary>
/// Species: Ascidia sydneiensis
/// NCBI TaxId: 79729
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ascidia_sydneiensis : Ascidia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ascidia sydneiensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ascidia_sydneiensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 79729;
}
