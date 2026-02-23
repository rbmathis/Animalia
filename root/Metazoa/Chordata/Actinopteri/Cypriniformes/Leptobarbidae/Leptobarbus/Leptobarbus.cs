using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leptobarbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leptobarbidae.Leptobarbus;

/// <summary>
/// Abstract class for Leptobarbus (genus).
/// NCBI TaxId: 227280
/// </summary>
public abstract class Leptobarbus : Leptobarbidae, ILeptobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227280;

    /// <inheritdoc />
    public virtual string GenusName => "Leptobarbus";

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
