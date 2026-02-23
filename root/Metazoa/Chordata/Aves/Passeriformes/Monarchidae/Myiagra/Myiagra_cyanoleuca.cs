namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Myiagra;

/// <summary>
/// Species: Myiagra cyanoleuca
/// NCBI TaxId: 107231
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myiagra_cyanoleuca : Myiagra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myiagra cyanoleuca";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myiagra_cyanoleuca";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 107231;
}
