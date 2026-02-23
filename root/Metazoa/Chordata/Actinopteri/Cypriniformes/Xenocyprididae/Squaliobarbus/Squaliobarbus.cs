using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Squaliobarbus;

/// <summary>
/// Abstract class for Squaliobarbus (genus).
/// NCBI TaxId: 75371
/// </summary>
public abstract class Squaliobarbus : Xenocyprididae, ISqualiobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Squaliobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75371;

    /// <inheritdoc />
    public virtual string GenusName => "Squaliobarbus";

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
