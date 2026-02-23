using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Alloophorus;

/// <summary>
/// Abstract class for Alloophorus (genus).
/// NCBI TaxId: 208312
/// </summary>
public abstract class Alloophorus : Goodeidae, IAlloophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alloophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208312;

    /// <inheritdoc />
    public virtual string GenusName => "Alloophorus";

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
