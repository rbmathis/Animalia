using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Novaculoides;

/// <summary>
/// Abstract class for Novaculoides (genus).
/// NCBI TaxId: 315408
/// </summary>
public abstract class Novaculoides : Labridae, INovaculoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Novaculoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 315408;

    /// <inheritdoc />
    public virtual string GenusName => "Novaculoides";

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
