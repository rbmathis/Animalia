using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Filicampus;

/// <summary>
/// Abstract class for Filicampus (genus).
/// NCBI TaxId: 1914717
/// </summary>
public abstract class Filicampus : Syngnathidae, IFilicampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Filicampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914717;

    /// <inheritdoc />
    public virtual string GenusName => "Filicampus";

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
