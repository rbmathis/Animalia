using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Pamphorichthys;

/// <summary>
/// Abstract class for Pamphorichthys (genus).
/// NCBI TaxId: 417477
/// </summary>
public abstract class Pamphorichthys : Poeciliidae, IPamphorichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pamphorichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 417477;

    /// <inheritdoc />
    public virtual string GenusName => "Pamphorichthys";

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
