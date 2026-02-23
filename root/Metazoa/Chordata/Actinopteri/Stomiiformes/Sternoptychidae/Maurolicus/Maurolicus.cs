using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Maurolicus;

/// <summary>
/// Abstract class for Maurolicus (genus).
/// NCBI TaxId: 68501
/// </summary>
public abstract class Maurolicus : Sternoptychidae, IMaurolicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Maurolicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68501;

    /// <inheritdoc />
    public virtual string GenusName => "Maurolicus";

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
