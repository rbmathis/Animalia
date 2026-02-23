using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mahidolia;

/// <summary>
/// Abstract class for Mahidolia (genus).
/// NCBI TaxId: 622423
/// </summary>
public abstract class Mahidolia : Gobiidae, IMahidolia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mahidolia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 622423;

    /// <inheritdoc />
    public virtual string GenusName => "Mahidolia";

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
