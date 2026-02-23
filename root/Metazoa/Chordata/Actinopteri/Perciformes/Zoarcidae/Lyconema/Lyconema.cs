using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lyconema;

/// <summary>
/// Abstract class for Lyconema (genus).
/// NCBI TaxId: 320592
/// </summary>
public abstract class Lyconema : Zoarcidae, ILyconema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lyconema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320592;

    /// <inheritdoc />
    public virtual string GenusName => "Lyconema";

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
