using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Pseudosphromenus;

/// <summary>
/// Abstract class for Pseudosphromenus (genus).
/// NCBI TaxId: 209239
/// </summary>
public abstract class Pseudosphromenus : Osphronemidae, IPseudosphromenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudosphromenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209239;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudosphromenus";

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
