using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Pseudocaranx;

/// <summary>
/// Abstract class for Pseudocaranx (genus).
/// NCBI TaxId: 349645
/// </summary>
public abstract class Pseudocaranx : Carangidae, IPseudocaranx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocaranx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 349645;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocaranx";

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
