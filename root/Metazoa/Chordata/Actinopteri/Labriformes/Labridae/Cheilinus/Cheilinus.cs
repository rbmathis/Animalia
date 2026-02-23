using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cheilinus;

/// <summary>
/// Abstract class for Cheilinus (genus).
/// NCBI TaxId: 202584
/// </summary>
public abstract class Cheilinus : Labridae, ICheilinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheilinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202584;

    /// <inheritdoc />
    public virtual string GenusName => "Cheilinus";

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
