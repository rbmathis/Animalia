using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Xiphocheilus;

/// <summary>
/// Abstract class for Xiphocheilus (genus).
/// NCBI TaxId: 241352
/// </summary>
public abstract class Xiphocheilus : Labridae, IXiphocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xiphocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241352;

    /// <inheritdoc />
    public virtual string GenusName => "Xiphocheilus";

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
