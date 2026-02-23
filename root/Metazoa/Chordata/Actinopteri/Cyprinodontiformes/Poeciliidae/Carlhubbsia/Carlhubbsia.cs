using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Carlhubbsia;

/// <summary>
/// Abstract class for Carlhubbsia (genus).
/// NCBI TaxId: 417466
/// </summary>
public abstract class Carlhubbsia : Poeciliidae, ICarlhubbsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carlhubbsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 417466;

    /// <inheritdoc />
    public virtual string GenusName => "Carlhubbsia";

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
