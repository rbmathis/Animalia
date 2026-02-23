using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Mastacembelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Mastacembelidae.Mastacembelus;

/// <summary>
/// Abstract class for Mastacembelus (genus).
/// NCBI TaxId: 94234
/// </summary>
public abstract class Mastacembelus : Mastacembelidae, IMastacembelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mastacembelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94234;

    /// <inheritdoc />
    public virtual string GenusName => "Mastacembelus";

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
