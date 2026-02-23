using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Brustiarius;

/// <summary>
/// Abstract class for Brustiarius (genus).
/// NCBI TaxId: 591308
/// </summary>
public abstract class Brustiarius : Ariidae, IBrustiarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brustiarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 591308;

    /// <inheritdoc />
    public virtual string GenusName => "Brustiarius";

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
