using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Indotestudo;

/// <summary>
/// Abstract class for Indotestudo (genus).
/// NCBI TaxId: 74919
/// </summary>
public abstract class Indotestudo : Testudinidae, IIndotestudo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Indotestudo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74919;

    /// <inheritdoc />
    public virtual string GenusName => "Indotestudo";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
