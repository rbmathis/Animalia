using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Strophidon;

/// <summary>
/// Abstract class for Strophidon (genus).
/// NCBI TaxId: 118150
/// </summary>
public abstract class Strophidon : Muraenidae, IStrophidon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Strophidon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118150;

    /// <inheritdoc />
    public virtual string GenusName => "Strophidon";

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
