using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Numididae.Acryllium;

/// <summary>
/// Abstract class for Acryllium (genus).
/// NCBI TaxId: 8991
/// </summary>
public abstract class Acryllium : Numididae, IAcryllium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acryllium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8991;

    /// <inheritdoc />
    public virtual string GenusName => "Acryllium";

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
