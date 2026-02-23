using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Cyematidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Cyematidae.Neocyema;

/// <summary>
/// Abstract class for Neocyema (genus).
/// NCBI TaxId: 2024704
/// </summary>
public abstract class Neocyema : Cyematidae, INeocyema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neocyema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2024704;

    /// <inheritdoc />
    public virtual string GenusName => "Neocyema";

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
