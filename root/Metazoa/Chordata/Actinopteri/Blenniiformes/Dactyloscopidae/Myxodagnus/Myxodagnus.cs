using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Dactyloscopidae.Myxodagnus;

/// <summary>
/// Abstract class for Myxodagnus (genus).
/// NCBI TaxId: 57825
/// </summary>
public abstract class Myxodagnus : Dactyloscopidae, IMyxodagnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myxodagnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57825;

    /// <inheritdoc />
    public virtual string GenusName => "Myxodagnus";

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
