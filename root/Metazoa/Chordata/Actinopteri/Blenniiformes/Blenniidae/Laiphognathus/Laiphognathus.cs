using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Laiphognathus;

/// <summary>
/// Abstract class for Laiphognathus (genus).
/// NCBI TaxId: 1405684
/// </summary>
public abstract class Laiphognathus : Blenniidae, ILaiphognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laiphognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1405684;

    /// <inheritdoc />
    public virtual string GenusName => "Laiphognathus";

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
