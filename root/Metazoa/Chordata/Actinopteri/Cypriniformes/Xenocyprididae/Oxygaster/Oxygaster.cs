using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Oxygaster;

/// <summary>
/// Abstract class for Oxygaster (genus).
/// NCBI TaxId: 999678
/// </summary>
public abstract class Oxygaster : Xenocyprididae, IOxygaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxygaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 999678;

    /// <inheritdoc />
    public virtual string GenusName => "Oxygaster";

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
