using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Ancistomus;

/// <summary>
/// Abstract class for Ancistomus (genus).
/// NCBI TaxId: 1633161
/// </summary>
public abstract class Ancistomus : Loricariidae, IAncistomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ancistomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633161;

    /// <inheritdoc />
    public virtual string GenusName => "Ancistomus";

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
