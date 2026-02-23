using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Idiolophorhynchus;

/// <summary>
/// Abstract class for Idiolophorhynchus (genus).
/// NCBI TaxId: 2696661
/// </summary>
public abstract class Idiolophorhynchus : Macrouridae, IIdiolophorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Idiolophorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696661;

    /// <inheritdoc />
    public virtual string GenusName => "Idiolophorhynchus";

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
