using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.Hyperoplus;

/// <summary>
/// Abstract class for Hyperoplus (genus).
/// NCBI TaxId: 508656
/// </summary>
public abstract class Hyperoplus : Ammodytidae, IHyperoplus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyperoplus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 508656;

    /// <inheritdoc />
    public virtual string GenusName => "Hyperoplus";

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
