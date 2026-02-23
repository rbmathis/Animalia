using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Aethotaxis;

/// <summary>
/// Abstract class for Aethotaxis (genus).
/// NCBI TaxId: 101499
/// </summary>
public abstract class Aethotaxis : Nototheniidae, IAethotaxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aethotaxis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 101499;

    /// <inheritdoc />
    public virtual string GenusName => "Aethotaxis";

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
