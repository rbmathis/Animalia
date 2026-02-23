using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Ophthalmolepis;

/// <summary>
/// Abstract class for Ophthalmolepis (genus).
/// NCBI TaxId: 241324
/// </summary>
public abstract class Ophthalmolepis : Labridae, IOphthalmolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophthalmolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241324;

    /// <inheritdoc />
    public virtual string GenusName => "Ophthalmolepis";

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
