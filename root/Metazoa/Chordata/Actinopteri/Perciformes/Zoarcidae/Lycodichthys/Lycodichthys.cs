using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycodichthys;

/// <summary>
/// Abstract class for Lycodichthys (genus).
/// NCBI TaxId: 8200
/// </summary>
public abstract class Lycodichthys : Zoarcidae, ILycodichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycodichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8200;

    /// <inheritdoc />
    public virtual string GenusName => "Lycodichthys";

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
