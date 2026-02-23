using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Rhyacichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Rhyacichthyidae.Protogobius;

/// <summary>
/// Abstract class for Protogobius (genus).
/// NCBI TaxId: 86221
/// </summary>
public abstract class Protogobius : Rhyacichthyidae, IProtogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Protogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86221;

    /// <inheritdoc />
    public virtual string GenusName => "Protogobius";

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
