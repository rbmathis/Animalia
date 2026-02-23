using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Gomphosus;

/// <summary>
/// Abstract class for Gomphosus (genus).
/// NCBI TaxId: 8248
/// </summary>
public abstract class Gomphosus : Labridae, IGomphosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gomphosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8248;

    /// <inheritdoc />
    public virtual string GenusName => "Gomphosus";

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
