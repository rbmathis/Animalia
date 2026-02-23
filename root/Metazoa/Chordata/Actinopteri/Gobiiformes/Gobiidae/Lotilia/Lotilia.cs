using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lotilia;

/// <summary>
/// Abstract class for Lotilia (genus).
/// NCBI TaxId: 1910790
/// </summary>
public abstract class Lotilia : Gobiidae, ILotilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lotilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1910790;

    /// <inheritdoc />
    public virtual string GenusName => "Lotilia";

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
