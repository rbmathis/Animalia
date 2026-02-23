using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobiosoma;

/// <summary>
/// Abstract class for Gobiosoma (genus).
/// NCBI TaxId: 166751
/// </summary>
public abstract class Gobiosoma : Gobiidae, IGobiosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobiosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166751;

    /// <inheritdoc />
    public virtual string GenusName => "Gobiosoma";

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
