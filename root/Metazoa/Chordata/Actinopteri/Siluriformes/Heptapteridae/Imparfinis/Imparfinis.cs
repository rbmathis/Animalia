using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Imparfinis;

/// <summary>
/// Abstract class for Imparfinis (genus).
/// NCBI TaxId: 164379
/// </summary>
public abstract class Imparfinis : Heptapteridae, IImparfinis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Imparfinis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 164379;

    /// <inheritdoc />
    public virtual string GenusName => "Imparfinis";

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
