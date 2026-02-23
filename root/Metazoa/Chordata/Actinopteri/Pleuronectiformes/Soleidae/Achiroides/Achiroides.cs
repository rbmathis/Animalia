using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Achiroides;

/// <summary>
/// Abstract class for Achiroides (genus).
/// NCBI TaxId: 366937
/// </summary>
public abstract class Achiroides : Soleidae, IAchiroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Achiroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 366937;

    /// <inheritdoc />
    public virtual string GenusName => "Achiroides";

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
