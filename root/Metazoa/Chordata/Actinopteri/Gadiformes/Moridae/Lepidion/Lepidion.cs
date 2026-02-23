using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Moridae.Lepidion;

/// <summary>
/// Abstract class for Lepidion (genus).
/// NCBI TaxId: 443789
/// </summary>
public abstract class Lepidion : Moridae, ILepidion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443789;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidion";

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
