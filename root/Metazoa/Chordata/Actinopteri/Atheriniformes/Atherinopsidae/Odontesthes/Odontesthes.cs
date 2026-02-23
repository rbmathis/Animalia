using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Odontesthes;

/// <summary>
/// Abstract class for Odontesthes (genus).
/// NCBI TaxId: 103865
/// </summary>
public abstract class Odontesthes : Atherinopsidae, IOdontesthes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontesthes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103865;

    /// <inheritdoc />
    public virtual string GenusName => "Odontesthes";

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
