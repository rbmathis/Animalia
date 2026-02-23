using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Cryptarius;

/// <summary>
/// Abstract class for Cryptarius (genus).
/// NCBI TaxId: 419351
/// </summary>
public abstract class Cryptarius : Ariidae, ICryptarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 419351;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptarius";

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
