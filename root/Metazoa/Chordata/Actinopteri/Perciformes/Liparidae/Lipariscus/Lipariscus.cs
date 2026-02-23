using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Lipariscus;

/// <summary>
/// Abstract class for Lipariscus (genus).
/// NCBI TaxId: 557404
/// </summary>
public abstract class Lipariscus : Liparidae, ILipariscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lipariscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 557404;

    /// <inheritdoc />
    public virtual string GenusName => "Lipariscus";

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
