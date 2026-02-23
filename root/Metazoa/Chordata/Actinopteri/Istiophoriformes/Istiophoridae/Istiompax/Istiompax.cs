using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae.Istiompax;

/// <summary>
/// Abstract class for Istiompax (genus).
/// NCBI TaxId: 1485181
/// </summary>
public abstract class Istiompax : Istiophoridae, IIstiompax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Istiompax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1485181;

    /// <inheritdoc />
    public virtual string GenusName => "Istiompax";

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
