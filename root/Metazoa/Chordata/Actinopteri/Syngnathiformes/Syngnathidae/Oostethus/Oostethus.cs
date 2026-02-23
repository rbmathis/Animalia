using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Oostethus;

/// <summary>
/// Abstract class for Oostethus (genus).
/// NCBI TaxId: 1652674
/// </summary>
public abstract class Oostethus : Syngnathidae, IOostethus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oostethus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1652674;

    /// <inheritdoc />
    public virtual string GenusName => "Oostethus";

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
