using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Parkraemeria;

/// <summary>
/// Abstract class for Parkraemeria (genus).
/// NCBI TaxId: 2507737
/// </summary>
public abstract class Parkraemeria : Gobiidae, IParkraemeria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parkraemeria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2507737;

    /// <inheritdoc />
    public virtual string GenusName => "Parkraemeria";

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
