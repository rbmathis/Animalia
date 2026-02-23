using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Salariopsis;

/// <summary>
/// Abstract class for Salariopsis (genus).
/// NCBI TaxId: 3036763
/// </summary>
public abstract class Salariopsis : Blenniidae, ISalariopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salariopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3036763;

    /// <inheritdoc />
    public virtual string GenusName => "Salariopsis";

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
