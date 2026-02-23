using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Pararius;

/// <summary>
/// Abstract class for Pararius (genus).
/// NCBI TaxId: 3363457
/// </summary>
public abstract class Pararius : Ariidae, IPararius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pararius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363457;

    /// <inheritdoc />
    public virtual string GenusName => "Pararius";

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
