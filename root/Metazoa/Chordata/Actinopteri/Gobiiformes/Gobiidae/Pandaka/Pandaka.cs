using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pandaka;

/// <summary>
/// Abstract class for Pandaka (genus).
/// NCBI TaxId: 186832
/// </summary>
public abstract class Pandaka : Gobiidae, IPandaka
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pandaka";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186832;

    /// <inheritdoc />
    public virtual string GenusName => "Pandaka";

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
