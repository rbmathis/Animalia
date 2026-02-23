namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiarchus;

/// <summary>
/// Species: Myiarchus yucatanensis
/// NCBI TaxId: 238985
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myiarchus_yucatanensis : Myiarchus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myiarchus yucatanensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myiarchus_yucatanensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 238985;
}
