using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Anarchopterus;

/// <summary>
/// Abstract class for Anarchopterus (genus).
/// NCBI TaxId: 1914713
/// </summary>
public abstract class Anarchopterus : Syngnathidae, IAnarchopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anarchopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914713;

    /// <inheritdoc />
    public virtual string GenusName => "Anarchopterus";

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
