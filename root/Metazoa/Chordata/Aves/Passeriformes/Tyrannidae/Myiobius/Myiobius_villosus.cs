namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiobius;

/// <summary>
/// Species: Myiobius villosus
/// NCBI TaxId: 495185
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myiobius_villosus : Myiobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myiobius villosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myiobius_villosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 495185;
}
