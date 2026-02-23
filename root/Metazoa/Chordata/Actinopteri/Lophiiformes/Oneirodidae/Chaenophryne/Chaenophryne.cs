using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Chaenophryne;

/// <summary>
/// Abstract class for Chaenophryne (genus).
/// NCBI TaxId: 412638
/// </summary>
public abstract class Chaenophryne : Oneirodidae, IChaenophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaenophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412638;

    /// <inheritdoc />
    public virtual string GenusName => "Chaenophryne";

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
