using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Bulbonaricus;

/// <summary>
/// Abstract class for Bulbonaricus (genus).
/// NCBI TaxId: 1772062
/// </summary>
public abstract class Bulbonaricus : Syngnathidae, IBulbonaricus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bulbonaricus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1772062;

    /// <inheritdoc />
    public virtual string GenusName => "Bulbonaricus";

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
