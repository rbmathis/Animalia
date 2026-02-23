using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Navigobius;

/// <summary>
/// Abstract class for Navigobius (genus).
/// NCBI TaxId: 1836938
/// </summary>
public abstract class Navigobius : Gobiidae, INavigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Navigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1836938;

    /// <inheritdoc />
    public virtual string GenusName => "Navigobius";

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
