using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Halicampus;

/// <summary>
/// Abstract class for Halicampus (genus).
/// NCBI TaxId: 161457
/// </summary>
public abstract class Halicampus : Syngnathidae, IHalicampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halicampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161457;

    /// <inheritdoc />
    public virtual string GenusName => "Halicampus";

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
