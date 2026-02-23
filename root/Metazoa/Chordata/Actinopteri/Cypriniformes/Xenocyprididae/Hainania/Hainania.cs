using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Hainania;

/// <summary>
/// Abstract class for Hainania (genus).
/// NCBI TaxId: 1354506
/// </summary>
public abstract class Hainania : Xenocyprididae, IHainania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hainania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1354506;

    /// <inheritdoc />
    public virtual string GenusName => "Hainania";

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
