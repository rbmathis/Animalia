using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae.Istiophorus;

/// <summary>
/// Abstract class for Istiophorus (genus).
/// NCBI TaxId: 13574
/// </summary>
public abstract class Istiophorus : Istiophoridae, IIstiophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Istiophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13574;

    /// <inheritdoc />
    public virtual string GenusName => "Istiophorus";

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
