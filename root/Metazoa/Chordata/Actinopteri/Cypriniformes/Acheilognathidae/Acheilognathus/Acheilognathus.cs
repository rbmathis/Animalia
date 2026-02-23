using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Acheilognathus;

/// <summary>
/// Abstract class for Acheilognathus (genus).
/// NCBI TaxId: 75333
/// </summary>
public abstract class Acheilognathus : Acheilognathidae, IAcheilognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acheilognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75333;

    /// <inheritdoc />
    public virtual string GenusName => "Acheilognathus";

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
