using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Mastacembelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Mastacembelidae.Macrognathus;

/// <summary>
/// Abstract class for Macrognathus (genus).
/// NCBI TaxId: 210628
/// </summary>
public abstract class Macrognathus : Mastacembelidae, IMacrognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210628;

    /// <inheritdoc />
    public virtual string GenusName => "Macrognathus";

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
