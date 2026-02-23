using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Platytroctes;

/// <summary>
/// Abstract class for Platytroctes (genus).
/// NCBI TaxId: 170201
/// </summary>
public abstract class Platytroctes : Platytroctidae, IPlatytroctes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platytroctes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170201;

    /// <inheritdoc />
    public virtual string GenusName => "Platytroctes";

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
