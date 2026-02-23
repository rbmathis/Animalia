using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Microcharacidium;

/// <summary>
/// Abstract class for Microcharacidium (genus).
/// NCBI TaxId: 2608221
/// </summary>
public abstract class Microcharacidium : Crenuchidae, IMicrocharacidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microcharacidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608221;

    /// <inheritdoc />
    public virtual string GenusName => "Microcharacidium";

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
