using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Millerichthys;

/// <summary>
/// Abstract class for Millerichthys (genus).
/// NCBI TaxId: 2588673
/// </summary>
public abstract class Millerichthys : Rivulidae, IMillerichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Millerichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2588673;

    /// <inheritdoc />
    public virtual string GenusName => "Millerichthys";

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
