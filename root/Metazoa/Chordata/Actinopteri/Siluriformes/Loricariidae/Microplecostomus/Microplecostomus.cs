using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Microplecostomus;

/// <summary>
/// Abstract class for Microplecostomus (genus).
/// NCBI TaxId: 1871679
/// </summary>
public abstract class Microplecostomus : Loricariidae, IMicroplecostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microplecostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1871679;

    /// <inheritdoc />
    public virtual string GenusName => "Microplecostomus";

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
