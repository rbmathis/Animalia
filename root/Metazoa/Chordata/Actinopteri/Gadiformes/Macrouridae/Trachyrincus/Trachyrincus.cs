using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Trachyrincus;

/// <summary>
/// Abstract class for Trachyrincus (genus).
/// NCBI TaxId: 241835
/// </summary>
public abstract class Trachyrincus : Macrouridae, ITrachyrincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachyrincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241835;

    /// <inheritdoc />
    public virtual string GenusName => "Trachyrincus";

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
