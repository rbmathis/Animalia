using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Brachyrhaphis;

/// <summary>
/// Abstract class for Brachyrhaphis (genus).
/// NCBI TaxId: 51554
/// </summary>
public abstract class Brachyrhaphis : Poeciliidae, IBrachyrhaphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyrhaphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51554;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyrhaphis";

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
