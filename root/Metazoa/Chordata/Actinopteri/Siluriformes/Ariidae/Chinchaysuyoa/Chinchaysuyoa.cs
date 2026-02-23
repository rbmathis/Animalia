using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Chinchaysuyoa;

/// <summary>
/// Abstract class for Chinchaysuyoa (genus).
/// NCBI TaxId: 2905215
/// </summary>
public abstract class Chinchaysuyoa : Ariidae, IChinchaysuyoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chinchaysuyoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2905215;

    /// <inheritdoc />
    public virtual string GenusName => "Chinchaysuyoa";

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
