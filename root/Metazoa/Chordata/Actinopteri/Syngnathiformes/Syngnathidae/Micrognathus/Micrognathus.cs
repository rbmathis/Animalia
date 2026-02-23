using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Micrognathus;

/// <summary>
/// Abstract class for Micrognathus (genus).
/// NCBI TaxId: 1914729
/// </summary>
public abstract class Micrognathus : Syngnathidae, IMicrognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micrognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914729;

    /// <inheritdoc />
    public virtual string GenusName => "Micrognathus";

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
