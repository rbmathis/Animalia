using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pteragogus;

/// <summary>
/// Abstract class for Pteragogus (genus).
/// NCBI TaxId: 202595
/// </summary>
public abstract class Pteragogus : Labridae, IPteragogus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteragogus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202595;

    /// <inheritdoc />
    public virtual string GenusName => "Pteragogus";

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
