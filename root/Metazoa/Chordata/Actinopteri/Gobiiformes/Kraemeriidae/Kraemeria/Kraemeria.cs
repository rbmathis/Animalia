using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Kraemeriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Kraemeriidae.Kraemeria;

/// <summary>
/// Abstract class for Kraemeria (genus).
/// NCBI TaxId: 86208
/// </summary>
public abstract class Kraemeria : Kraemeriidae, IKraemeria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kraemeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86208;

    /// <inheritdoc />
    public virtual string GenusName => "Kraemeria";

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
