using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pseudocheilinus;

/// <summary>
/// Abstract class for Pseudocheilinus (genus).
/// NCBI TaxId: 241334
/// </summary>
public abstract class Pseudocheilinus : Labridae, IPseudocheilinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocheilinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241334;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocheilinus";

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
