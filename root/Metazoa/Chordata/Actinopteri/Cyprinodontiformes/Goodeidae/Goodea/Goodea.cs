using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Goodea;

/// <summary>
/// Abstract class for Goodea (genus).
/// NCBI TaxId: 208335
/// </summary>
public abstract class Goodea : Goodeidae, IGoodea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Goodea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208335;

    /// <inheritdoc />
    public virtual string GenusName => "Goodea";

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
