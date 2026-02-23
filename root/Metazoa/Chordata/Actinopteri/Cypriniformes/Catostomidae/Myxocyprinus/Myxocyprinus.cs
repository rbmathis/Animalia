using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Myxocyprinus;

/// <summary>
/// Abstract class for Myxocyprinus (genus).
/// NCBI TaxId: 70542
/// </summary>
public abstract class Myxocyprinus : Catostomidae, IMyxocyprinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myxocyprinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70542;

    /// <inheritdoc />
    public virtual string GenusName => "Myxocyprinus";

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
