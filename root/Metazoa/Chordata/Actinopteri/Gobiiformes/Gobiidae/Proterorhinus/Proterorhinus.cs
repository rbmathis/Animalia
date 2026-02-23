using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Proterorhinus;

/// <summary>
/// Abstract class for Proterorhinus (genus).
/// NCBI TaxId: 47309
/// </summary>
public abstract class Proterorhinus : Gobiidae, IProterorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proterorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47309;

    /// <inheritdoc />
    public virtual string GenusName => "Proterorhinus";

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
