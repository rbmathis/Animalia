using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Aphyonus;

/// <summary>
/// Abstract class for Aphyonus (genus).
/// NCBI TaxId: 1843785
/// </summary>
public abstract class Aphyonus : Ophidiidae, IAphyonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphyonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1843785;

    /// <inheritdoc />
    public virtual string GenusName => "Aphyonus";

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
