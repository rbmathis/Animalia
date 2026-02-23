using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Barbantus;

/// <summary>
/// Abstract class for Barbantus (genus).
/// NCBI TaxId: 1459850
/// </summary>
public abstract class Barbantus : Platytroctidae, IBarbantus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barbantus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1459850;

    /// <inheritdoc />
    public virtual string GenusName => "Barbantus";

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
