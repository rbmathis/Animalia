using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Salmostoma;

/// <summary>
/// Abstract class for Salmostoma (genus).
/// NCBI TaxId: 1249054
/// </summary>
public abstract class Salmostoma : Danionidae, ISalmostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salmostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1249054;

    /// <inheritdoc />
    public virtual string GenusName => "Salmostoma";

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
