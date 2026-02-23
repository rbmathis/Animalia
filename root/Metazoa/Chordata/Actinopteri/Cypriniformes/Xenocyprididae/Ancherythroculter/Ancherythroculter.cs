using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Ancherythroculter;

/// <summary>
/// Abstract class for Ancherythroculter (genus).
/// NCBI TaxId: 263418
/// </summary>
public abstract class Ancherythroculter : Xenocyprididae, IAncherythroculter
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ancherythroculter";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 263418;

    /// <inheritdoc />
    public virtual string GenusName => "Ancherythroculter";

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
