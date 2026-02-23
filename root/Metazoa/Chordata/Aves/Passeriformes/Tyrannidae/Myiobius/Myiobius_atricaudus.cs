namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiobius;

/// <summary>
/// Species: Myiobius atricaudus
/// NCBI TaxId: 478609
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myiobius_atricaudus : Myiobius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myiobius atricaudus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myiobius_atricaudus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 478609;
}
