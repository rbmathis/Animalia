using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Bathyonus;

/// <summary>
/// Abstract class for Bathyonus (genus).
/// NCBI TaxId: 3095261
/// </summary>
public abstract class Bathyonus : Ophidiidae, IBathyonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathyonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3095261;

    /// <inheritdoc />
    public virtual string GenusName => "Bathyonus";

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
