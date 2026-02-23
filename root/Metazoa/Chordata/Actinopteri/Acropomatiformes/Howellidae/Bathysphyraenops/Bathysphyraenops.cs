using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Howellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Howellidae.Bathysphyraenops;

/// <summary>
/// Abstract class for Bathysphyraenops (genus).
/// NCBI TaxId: 2838354
/// </summary>
public abstract class Bathysphyraenops : Howellidae, IBathysphyraenops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathysphyraenops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2838354;

    /// <inheritdoc />
    public virtual string GenusName => "Bathysphyraenops";

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
