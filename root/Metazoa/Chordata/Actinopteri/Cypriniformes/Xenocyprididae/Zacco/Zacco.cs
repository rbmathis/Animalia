using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Zacco;

/// <summary>
/// Abstract class for Zacco (genus).
/// NCBI TaxId: 80809
/// </summary>
public abstract class Zacco : Xenocyprididae, IZacco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zacco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80809;

    /// <inheritdoc />
    public virtual string GenusName => "Zacco";

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
