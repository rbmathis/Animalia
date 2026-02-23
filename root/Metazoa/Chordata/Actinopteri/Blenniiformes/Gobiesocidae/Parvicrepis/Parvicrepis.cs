using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Parvicrepis;

/// <summary>
/// Abstract class for Parvicrepis (genus).
/// NCBI TaxId: 1500707
/// </summary>
public abstract class Parvicrepis : Gobiesocidae, IParvicrepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parvicrepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1500707;

    /// <inheritdoc />
    public virtual string GenusName => "Parvicrepis";

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
