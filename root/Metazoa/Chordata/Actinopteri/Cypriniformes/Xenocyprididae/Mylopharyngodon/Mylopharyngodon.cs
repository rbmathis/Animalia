using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Mylopharyngodon;

/// <summary>
/// Abstract class for Mylopharyngodon (genus).
/// NCBI TaxId: 75355
/// </summary>
public abstract class Mylopharyngodon : Xenocyprididae, IMylopharyngodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mylopharyngodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75355;

    /// <inheritdoc />
    public virtual string GenusName => "Mylopharyngodon";

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
