using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Kuiterichthys;

/// <summary>
/// Abstract class for Kuiterichthys (genus).
/// NCBI TaxId: 882773
/// </summary>
public abstract class Kuiterichthys : Antennariidae, IKuiterichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kuiterichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882773;

    /// <inheritdoc />
    public virtual string GenusName => "Kuiterichthys";

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
