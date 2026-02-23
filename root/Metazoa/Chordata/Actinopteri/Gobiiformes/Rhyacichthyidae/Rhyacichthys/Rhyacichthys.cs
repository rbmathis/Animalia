using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Rhyacichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Rhyacichthyidae.Rhyacichthys;

/// <summary>
/// Abstract class for Rhyacichthys (genus).
/// NCBI TaxId: 86219
/// </summary>
public abstract class Rhyacichthys : Rhyacichthyidae, IRhyacichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhyacichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86219;

    /// <inheritdoc />
    public virtual string GenusName => "Rhyacichthys";

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
