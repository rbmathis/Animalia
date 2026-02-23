using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Austrolethops;

/// <summary>
/// Abstract class for Austrolethops (genus).
/// NCBI TaxId: 2888843
/// </summary>
public abstract class Austrolethops : Gobiidae, IAustrolethops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Austrolethops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2888843;

    /// <inheritdoc />
    public virtual string GenusName => "Austrolethops";

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
