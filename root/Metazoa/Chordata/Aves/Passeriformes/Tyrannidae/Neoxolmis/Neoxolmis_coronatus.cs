namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Neoxolmis;

/// <summary>
/// Species: Neoxolmis coronatus
/// NCBI TaxId: 3150200
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Neoxolmis_coronatus : Neoxolmis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Neoxolmis coronatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Neoxolmis_coronatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150200;
}
