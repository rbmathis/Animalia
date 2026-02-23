using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Labroides;

/// <summary>
/// Abstract class for Labroides (genus).
/// NCBI TaxId: 241307
/// </summary>
public abstract class Labroides : Labridae, ILabroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241307;

    /// <inheritdoc />
    public virtual string GenusName => "Labroides";

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
