using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Priapella;

/// <summary>
/// Abstract class for Priapella (genus).
/// NCBI TaxId: 32463
/// </summary>
public abstract class Priapella : Poeciliidae, IPriapella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Priapella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32463;

    /// <inheritdoc />
    public virtual string GenusName => "Priapella";

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
