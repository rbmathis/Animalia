using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Toxabramis;

/// <summary>
/// Abstract class for Toxabramis (genus).
/// NCBI TaxId: 291824
/// </summary>
public abstract class Toxabramis : Xenocyprididae, IToxabramis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Toxabramis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 291824;

    /// <inheritdoc />
    public virtual string GenusName => "Toxabramis";

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
