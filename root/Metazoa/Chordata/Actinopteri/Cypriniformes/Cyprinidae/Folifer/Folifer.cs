using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Folifer;

/// <summary>
/// Abstract class for Folifer (genus).
/// NCBI TaxId: 464758
/// </summary>
public abstract class Folifer : Cyprinidae, IFolifer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Folifer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 464758;

    /// <inheritdoc />
    public virtual string GenusName => "Folifer";

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
