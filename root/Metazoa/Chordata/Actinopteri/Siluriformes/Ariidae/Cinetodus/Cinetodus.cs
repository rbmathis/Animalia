using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Cinetodus;

/// <summary>
/// Abstract class for Cinetodus (genus).
/// NCBI TaxId: 591315
/// </summary>
public abstract class Cinetodus : Ariidae, ICinetodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cinetodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 591315;

    /// <inheritdoc />
    public virtual string GenusName => "Cinetodus";

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
