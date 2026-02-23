using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Wetmorella;

/// <summary>
/// Abstract class for Wetmorella (genus).
/// NCBI TaxId: 241350
/// </summary>
public abstract class Wetmorella : Labridae, IWetmorella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Wetmorella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241350;

    /// <inheritdoc />
    public virtual string GenusName => "Wetmorella";

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
