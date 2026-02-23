using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Elassodiscus;

/// <summary>
/// Abstract class for Elassodiscus (genus).
/// NCBI TaxId: 446811
/// </summary>
public abstract class Elassodiscus : Liparidae, IElassodiscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elassodiscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 446811;

    /// <inheritdoc />
    public virtual string GenusName => "Elassodiscus";

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
