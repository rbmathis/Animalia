using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Luciocyprinus;

/// <summary>
/// Abstract class for Luciocyprinus (genus).
/// NCBI TaxId: 1219348
/// </summary>
public abstract class Luciocyprinus : Cyprinidae, ILuciocyprinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Luciocyprinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1219348;

    /// <inheritdoc />
    public virtual string GenusName => "Luciocyprinus";

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
