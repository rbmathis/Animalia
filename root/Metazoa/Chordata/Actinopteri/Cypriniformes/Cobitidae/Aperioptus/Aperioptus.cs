using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Aperioptus;

/// <summary>
/// Abstract class for Aperioptus (genus).
/// NCBI TaxId: 1817957
/// </summary>
public abstract class Aperioptus : Cobitidae, IAperioptus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aperioptus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1817957;

    /// <inheritdoc />
    public virtual string GenusName => "Aperioptus";

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
