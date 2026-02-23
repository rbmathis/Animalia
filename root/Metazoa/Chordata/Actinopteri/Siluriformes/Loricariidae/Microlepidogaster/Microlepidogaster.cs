using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Microlepidogaster;

/// <summary>
/// Abstract class for Microlepidogaster (genus).
/// NCBI TaxId: 510790
/// </summary>
public abstract class Microlepidogaster : Loricariidae, IMicrolepidogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microlepidogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 510790;

    /// <inheritdoc />
    public virtual string GenusName => "Microlepidogaster";

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
