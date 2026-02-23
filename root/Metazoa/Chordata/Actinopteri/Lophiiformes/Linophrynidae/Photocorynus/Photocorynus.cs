using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Linophrynidae.Photocorynus;

/// <summary>
/// Abstract class for Photocorynus (genus).
/// NCBI TaxId: 2656796
/// </summary>
public abstract class Photocorynus : Linophrynidae, IPhotocorynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Photocorynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2656796;

    /// <inheritdoc />
    public virtual string GenusName => "Photocorynus";

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
