using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Selaroides;

/// <summary>
/// Abstract class for Selaroides (genus).
/// NCBI TaxId: 173310
/// </summary>
public abstract class Selaroides : Carangidae, ISelaroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Selaroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173310;

    /// <inheritdoc />
    public virtual string GenusName => "Selaroides";

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
