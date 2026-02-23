using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Trachonurus;

/// <summary>
/// Abstract class for Trachonurus (genus).
/// NCBI TaxId: 630745
/// </summary>
public abstract class Trachonurus : Macrouridae, ITrachonurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachonurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 630745;

    /// <inheritdoc />
    public virtual string GenusName => "Trachonurus";

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
