using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Xenolumpenus;

/// <summary>
/// Abstract class for Xenolumpenus (genus).
/// NCBI TaxId: 1317008
/// </summary>
public abstract class Xenolumpenus : Stichaeidae, IXenolumpenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenolumpenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1317008;

    /// <inheritdoc />
    public virtual string GenusName => "Xenolumpenus";

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
