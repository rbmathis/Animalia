using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Boraras;

/// <summary>
/// Abstract class for Boraras (genus).
/// NCBI TaxId: 432403
/// </summary>
public abstract class Boraras : Danionidae, IBoraras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boraras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432403;

    /// <inheritdoc />
    public virtual string GenusName => "Boraras";

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
