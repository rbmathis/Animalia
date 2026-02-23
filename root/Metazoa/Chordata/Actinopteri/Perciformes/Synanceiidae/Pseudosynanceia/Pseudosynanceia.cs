using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Synanceiidae.Pseudosynanceia;

/// <summary>
/// Abstract class for Pseudosynanceia (genus).
/// NCBI TaxId: 2951015
/// </summary>
public abstract class Pseudosynanceia : Synanceiidae, IPseudosynanceia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudosynanceia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2951015;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudosynanceia";

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
