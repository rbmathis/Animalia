using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Coryphaenoides;

/// <summary>
/// Abstract class for Coryphaenoides (genus).
/// NCBI TaxId: 76797
/// </summary>
public abstract class Coryphaenoides : Macrouridae, ICoryphaenoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coryphaenoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76797;

    /// <inheritdoc />
    public virtual string GenusName => "Coryphaenoides";

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
