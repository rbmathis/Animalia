using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ariidae.Potamarius;

/// <summary>
/// Abstract class for Potamarius (genus).
/// NCBI TaxId: 419347
/// </summary>
public abstract class Potamarius : Ariidae, IPotamarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Potamarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 419347;

    /// <inheritdoc />
    public virtual string GenusName => "Potamarius";

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
