using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Stephanoberycidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Stephanoberycidae.Stephanoberyx;

/// <summary>
/// Abstract class for Stephanoberyx (genus).
/// NCBI TaxId: 2996728
/// </summary>
public abstract class Stephanoberyx : Stephanoberycidae, IStephanoberyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stephanoberyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2996728;

    /// <inheritdoc />
    public virtual string GenusName => "Stephanoberyx";

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
