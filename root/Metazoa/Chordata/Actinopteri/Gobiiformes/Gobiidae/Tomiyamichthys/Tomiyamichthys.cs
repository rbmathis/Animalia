using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Tomiyamichthys;

/// <summary>
/// Abstract class for Tomiyamichthys (genus).
/// NCBI TaxId: 622422
/// </summary>
public abstract class Tomiyamichthys : Gobiidae, ITomiyamichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tomiyamichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 622422;

    /// <inheritdoc />
    public virtual string GenusName => "Tomiyamichthys";

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
