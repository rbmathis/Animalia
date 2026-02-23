using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Apalopteron;

/// <summary>
/// Abstract class for Apalopteron (genus).
/// NCBI TaxId: 43154
/// </summary>
public abstract class Apalopteron : Zosteropidae, IApalopteron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apalopteron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43154;

    /// <inheritdoc />
    public virtual string GenusName => "Apalopteron";

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
