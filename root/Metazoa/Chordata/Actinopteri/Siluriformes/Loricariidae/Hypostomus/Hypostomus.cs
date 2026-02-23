using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hypostomus;

/// <summary>
/// Abstract class for Hypostomus (genus).
/// NCBI TaxId: 36713
/// </summary>
public abstract class Hypostomus : Loricariidae, IHypostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36713;

    /// <inheritdoc />
    public virtual string GenusName => "Hypostomus";

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
