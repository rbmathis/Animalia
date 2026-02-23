using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Argolebias;

/// <summary>
/// Abstract class for Argolebias (genus).
/// NCBI TaxId: 3081131
/// </summary>
public abstract class Argolebias : Rivulidae, IArgolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Argolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3081131;

    /// <inheritdoc />
    public virtual string GenusName => "Argolebias";

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
