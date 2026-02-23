using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Oneirodes;

/// <summary>
/// Abstract class for Oneirodes (genus).
/// NCBI TaxId: 242954
/// </summary>
public abstract class Oneirodes : Oneirodidae, IOneirodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oneirodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 242954;

    /// <inheritdoc />
    public virtual string GenusName => "Oneirodes";

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
