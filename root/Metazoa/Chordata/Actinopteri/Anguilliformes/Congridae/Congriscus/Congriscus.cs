using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Congriscus;

/// <summary>
/// Abstract class for Congriscus (genus).
/// NCBI TaxId: 1604599
/// </summary>
public abstract class Congriscus : Congridae, ICongriscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Congriscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1604599;

    /// <inheritdoc />
    public virtual string GenusName => "Congriscus";

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
