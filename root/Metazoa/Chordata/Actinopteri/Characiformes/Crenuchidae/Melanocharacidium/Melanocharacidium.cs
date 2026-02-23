using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Melanocharacidium;

/// <summary>
/// Abstract class for Melanocharacidium (genus).
/// NCBI TaxId: 304085
/// </summary>
public abstract class Melanocharacidium : Crenuchidae, IMelanocharacidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanocharacidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304085;

    /// <inheritdoc />
    public virtual string GenusName => "Melanocharacidium";

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
