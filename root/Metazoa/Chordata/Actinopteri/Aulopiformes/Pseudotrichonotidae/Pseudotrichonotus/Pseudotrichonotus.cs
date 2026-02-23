using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Pseudotrichonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Pseudotrichonotidae.Pseudotrichonotus;

/// <summary>
/// Abstract class for Pseudotrichonotus (genus).
/// NCBI TaxId: 172136
/// </summary>
public abstract class Pseudotrichonotus : Pseudotrichonotidae, IPseudotrichonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudotrichonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172136;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudotrichonotus";

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
