using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Gadomus;

/// <summary>
/// Abstract class for Gadomus (genus).
/// NCBI TaxId: 630728
/// </summary>
public abstract class Gadomus : Macrouridae, IGadomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gadomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 630728;

    /// <inheritdoc />
    public virtual string GenusName => "Gadomus";

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
