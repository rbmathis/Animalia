using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Cetostoma;

/// <summary>
/// Abstract class for Cetostoma (genus).
/// NCBI TaxId: 88670
/// </summary>
public abstract class Cetostoma : Cetomimidae, ICetostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cetostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88670;

    /// <inheritdoc />
    public virtual string GenusName => "Cetostoma";

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
