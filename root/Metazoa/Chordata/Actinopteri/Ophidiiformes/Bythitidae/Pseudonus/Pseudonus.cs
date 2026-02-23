using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Pseudonus;

/// <summary>
/// Abstract class for Pseudonus (genus).
/// NCBI TaxId: 3362213
/// </summary>
public abstract class Pseudonus : Bythitidae, IPseudonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362213;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudonus";

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
