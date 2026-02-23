using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Paraselene;

/// <summary>
/// Abstract class for Paraselene (genus).
/// NCBI TaxId: 3049892
/// </summary>
public abstract class Paraselene : Carangidae, IParaselene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraselene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049892;

    /// <inheritdoc />
    public virtual string GenusName => "Paraselene";

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
