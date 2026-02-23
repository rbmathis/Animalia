namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Myiagra;

/// <summary>
/// Species: Myiagra ruficollis
/// NCBI TaxId: 1329780
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myiagra_ruficollis : Myiagra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myiagra ruficollis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myiagra_ruficollis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1329780;
}
