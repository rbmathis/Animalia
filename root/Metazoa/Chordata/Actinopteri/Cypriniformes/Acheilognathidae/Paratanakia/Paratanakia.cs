using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Paratanakia;

/// <summary>
/// Abstract class for Paratanakia (genus).
/// NCBI TaxId: 2977126
/// </summary>
public abstract class Paratanakia : Acheilognathidae, IParatanakia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paratanakia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2977126;

    /// <inheritdoc />
    public virtual string GenusName => "Paratanakia";

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
