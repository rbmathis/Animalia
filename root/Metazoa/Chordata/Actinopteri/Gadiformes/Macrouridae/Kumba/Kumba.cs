using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Kumba;

/// <summary>
/// Abstract class for Kumba (genus).
/// NCBI TaxId: 2974559
/// </summary>
public abstract class Kumba : Macrouridae, IKumba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kumba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2974559;

    /// <inheritdoc />
    public virtual string GenusName => "Kumba";

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
