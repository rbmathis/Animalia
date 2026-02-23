using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Cetomimidae.Mirapinna;

/// <summary>
/// Abstract class for Mirapinna (genus).
/// NCBI TaxId: 565085
/// </summary>
public abstract class Mirapinna : Cetomimidae, IMirapinna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mirapinna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 565085;

    /// <inheritdoc />
    public virtual string GenusName => "Mirapinna";

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
