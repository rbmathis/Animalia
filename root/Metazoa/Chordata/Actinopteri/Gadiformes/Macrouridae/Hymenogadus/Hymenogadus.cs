using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Hymenogadus;

/// <summary>
/// Abstract class for Hymenogadus (genus).
/// NCBI TaxId: 1508084
/// </summary>
public abstract class Hymenogadus : Macrouridae, IHymenogadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hymenogadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1508084;

    /// <inheritdoc />
    public virtual string GenusName => "Hymenogadus";

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
