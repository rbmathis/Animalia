using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Parosphromenus;

/// <summary>
/// Abstract class for Parosphromenus (genus).
/// NCBI TaxId: 209236
/// </summary>
public abstract class Parosphromenus : Osphronemidae, IParosphromenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parosphromenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209236;

    /// <inheritdoc />
    public virtual string GenusName => "Parosphromenus";

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
