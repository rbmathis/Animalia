using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Solegnathus;

/// <summary>
/// Abstract class for Solegnathus (genus).
/// NCBI TaxId: 161472
/// </summary>
public abstract class Solegnathus : Syngnathidae, ISolegnathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Solegnathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161472;

    /// <inheritdoc />
    public virtual string GenusName => "Solegnathus";

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
