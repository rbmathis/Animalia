using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Idiolychnus;

/// <summary>
/// Abstract class for Idiolychnus (genus).
/// NCBI TaxId: 2968243
/// </summary>
public abstract class Idiolychnus : Myctophidae, IIdiolychnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Idiolychnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2968243;

    /// <inheritdoc />
    public virtual string GenusName => "Idiolychnus";

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
