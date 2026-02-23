using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.Cualac;

/// <summary>
/// Abstract class for Cualac (genus).
/// NCBI TaxId: 30739
/// </summary>
public abstract class Cualac : Cyprinodontidae, ICualac
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cualac";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30739;

    /// <inheritdoc />
    public virtual string GenusName => "Cualac";

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
