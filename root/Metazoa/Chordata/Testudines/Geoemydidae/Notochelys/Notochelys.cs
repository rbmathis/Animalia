using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Notochelys;

/// <summary>
/// Abstract class for Notochelys (genus).
/// NCBI TaxId: 204957
/// </summary>
public abstract class Notochelys : Geoemydidae, INotochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 204957;

    /// <inheritdoc />
    public virtual string GenusName => "Notochelys";

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
