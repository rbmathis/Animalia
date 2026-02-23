using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Micromoema;

/// <summary>
/// Abstract class for Micromoema (genus).
/// NCBI TaxId: 135314
/// </summary>
public abstract class Micromoema : Rivulidae, IMicromoema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micromoema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135314;

    /// <inheritdoc />
    public virtual string GenusName => "Micromoema";

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
