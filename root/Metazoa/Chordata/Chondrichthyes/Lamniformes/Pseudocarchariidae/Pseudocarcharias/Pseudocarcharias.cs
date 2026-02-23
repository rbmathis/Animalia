using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Pseudocarchariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Pseudocarchariidae.Pseudocarcharias;

/// <summary>
/// Abstract class for Pseudocarcharias (genus).
/// NCBI TaxId: 57990
/// </summary>
public abstract class Pseudocarcharias : Pseudocarchariidae, IPseudocarcharias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocarcharias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57990;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocarcharias";

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
