using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Anampses;

/// <summary>
/// Abstract class for Anampses (genus).
/// NCBI TaxId: 241262
/// </summary>
public abstract class Anampses : Labridae, IAnampses
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anampses";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241262;

    /// <inheritdoc />
    public virtual string GenusName => "Anampses";

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
