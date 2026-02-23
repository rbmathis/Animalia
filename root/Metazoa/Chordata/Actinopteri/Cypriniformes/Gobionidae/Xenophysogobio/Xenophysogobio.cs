using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Xenophysogobio;

/// <summary>
/// Abstract class for Xenophysogobio (genus).
/// NCBI TaxId: 180936
/// </summary>
public abstract class Xenophysogobio : Gobionidae, IXenophysogobio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenophysogobio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 180936;

    /// <inheritdoc />
    public virtual string GenusName => "Xenophysogobio";

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
