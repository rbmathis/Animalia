namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Myiagra;

/// <summary>
/// Species: Myiagra erythrops
/// NCBI TaxId: 1389791
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myiagra_erythrops : Myiagra
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myiagra erythrops";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myiagra_erythrops";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1389791;
}
