using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Pseudobunocephalus;

/// <summary>
/// Abstract class for Pseudobunocephalus (genus).
/// NCBI TaxId: 1312663
/// </summary>
public abstract class Pseudobunocephalus : Aspredinidae, IPseudobunocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudobunocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1312663;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudobunocephalus";

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
