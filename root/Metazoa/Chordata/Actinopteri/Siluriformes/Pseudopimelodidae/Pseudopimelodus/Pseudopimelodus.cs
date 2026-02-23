using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Pseudopimelodus;

/// <summary>
/// Abstract class for Pseudopimelodus (genus).
/// NCBI TaxId: 255575
/// </summary>
public abstract class Pseudopimelodus : Pseudopimelodidae, IPseudopimelodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudopimelodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255575;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudopimelodus";

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
