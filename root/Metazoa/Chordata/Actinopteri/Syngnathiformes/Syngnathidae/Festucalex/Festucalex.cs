using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Festucalex;

/// <summary>
/// Abstract class for Festucalex (genus).
/// NCBI TaxId: 1073242
/// </summary>
public abstract class Festucalex : Syngnathidae, IFestucalex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Festucalex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1073242;

    /// <inheritdoc />
    public virtual string GenusName => "Festucalex";

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
