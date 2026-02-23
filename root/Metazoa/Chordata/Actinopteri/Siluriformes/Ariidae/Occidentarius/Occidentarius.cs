using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Occidentarius;

/// <summary>
/// Abstract class for Occidentarius (genus).
/// NCBI TaxId: 1198623
/// </summary>
public abstract class Occidentarius : Ariidae, IOccidentarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Occidentarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1198623;

    /// <inheritdoc />
    public virtual string GenusName => "Occidentarius";

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
