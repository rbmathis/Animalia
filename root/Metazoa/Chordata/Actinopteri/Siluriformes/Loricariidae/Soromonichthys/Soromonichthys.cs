using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Soromonichthys;

/// <summary>
/// Abstract class for Soromonichthys (genus).
/// NCBI TaxId: 1633157
/// </summary>
public abstract class Soromonichthys : Loricariidae, ISoromonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Soromonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633157;

    /// <inheritdoc />
    public virtual string GenusName => "Soromonichthys";

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
