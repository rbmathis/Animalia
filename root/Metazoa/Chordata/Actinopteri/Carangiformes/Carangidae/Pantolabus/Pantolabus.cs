using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Pantolabus;

/// <summary>
/// Abstract class for Pantolabus (genus).
/// NCBI TaxId: 2035745
/// </summary>
public abstract class Pantolabus : Carangidae, IPantolabus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pantolabus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2035745;

    /// <inheritdoc />
    public virtual string GenusName => "Pantolabus";

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
