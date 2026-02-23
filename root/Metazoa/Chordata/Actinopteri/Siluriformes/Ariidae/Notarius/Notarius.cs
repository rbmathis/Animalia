using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Notarius;

/// <summary>
/// Abstract class for Notarius (genus).
/// NCBI TaxId: 286639
/// </summary>
public abstract class Notarius : Ariidae, INotarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286639;

    /// <inheritdoc />
    public virtual string GenusName => "Notarius";

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
