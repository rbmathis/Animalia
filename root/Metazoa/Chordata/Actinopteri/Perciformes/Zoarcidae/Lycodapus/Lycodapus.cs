using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycodapus;

/// <summary>
/// Abstract class for Lycodapus (genus).
/// NCBI TaxId: 433410
/// </summary>
public abstract class Lycodapus : Zoarcidae, ILycodapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycodapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 433410;

    /// <inheritdoc />
    public virtual string GenusName => "Lycodapus";

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
