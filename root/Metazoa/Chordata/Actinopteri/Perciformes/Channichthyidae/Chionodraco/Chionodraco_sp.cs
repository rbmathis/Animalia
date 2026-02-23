namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Chionodraco;

/// <summary>
/// Species: Chionodraco sp.
/// NCBI TaxId: 3420939
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chionodraco_sp : Chionodraco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chionodraco sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chionodraco_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3420939;
}
