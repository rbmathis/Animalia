using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Selene;

/// <summary>
/// Abstract class for Selene (genus).
/// NCBI TaxId: 179363
/// </summary>
public abstract class Selene : Carangidae, ISelene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Selene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 179363;

    /// <inheritdoc />
    public virtual string GenusName => "Selene";

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
