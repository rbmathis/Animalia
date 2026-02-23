using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Lochmias;

/// <summary>
/// Abstract class for Lochmias (genus).
/// NCBI TaxId: 183158
/// </summary>
public abstract class Lochmias : Furnariidae, ILochmias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lochmias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183158;

    /// <inheritdoc />
    public virtual string GenusName => "Lochmias";

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
