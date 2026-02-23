using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Girardinus;

/// <summary>
/// Abstract class for Girardinus (genus).
/// NCBI TaxId: 55105
/// </summary>
public abstract class Girardinus : Poeciliidae, IGirardinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Girardinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55105;

    /// <inheritdoc />
    public virtual string GenusName => "Girardinus";

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
