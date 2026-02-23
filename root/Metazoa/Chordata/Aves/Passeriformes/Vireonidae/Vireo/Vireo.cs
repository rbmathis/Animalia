using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae.Vireo;

/// <summary>
/// Abstract class for Vireo (genus).
/// NCBI TaxId: 28732
/// </summary>
public abstract class Vireo : Vireonidae, IVireo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vireo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28732;

    /// <inheritdoc />
    public virtual string GenusName => "Vireo";

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
