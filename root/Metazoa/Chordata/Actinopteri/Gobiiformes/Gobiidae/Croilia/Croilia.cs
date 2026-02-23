using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Croilia;

/// <summary>
/// Abstract class for Croilia (genus).
/// NCBI TaxId: 990977
/// </summary>
public abstract class Croilia : Gobiidae, ICroilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Croilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990977;

    /// <inheritdoc />
    public virtual string GenusName => "Croilia";

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
