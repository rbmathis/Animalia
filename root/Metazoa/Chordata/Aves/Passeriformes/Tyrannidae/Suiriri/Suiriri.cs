using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Suiriri;

/// <summary>
/// Abstract class for Suiriri (genus).
/// NCBI TaxId: 456429
/// </summary>
public abstract class Suiriri : Tyrannidae, ISuiriri
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Suiriri";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 456429;

    /// <inheritdoc />
    public virtual string GenusName => "Suiriri";

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
