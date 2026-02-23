using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Selar;

/// <summary>
/// Abstract class for Selar (genus).
/// NCBI TaxId: 146139
/// </summary>
public abstract class Selar : Carangidae, ISelar
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Selar";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 146139;

    /// <inheritdoc />
    public virtual string GenusName => "Selar";

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
