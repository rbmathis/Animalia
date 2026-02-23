using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Pristigasteridae.Opisthopterus;

/// <summary>
/// Abstract class for Opisthopterus (genus).
/// NCBI TaxId: 1267196
/// </summary>
public abstract class Opisthopterus : Pristigasteridae, IOpisthopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Opisthopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1267196;

    /// <inheritdoc />
    public virtual string GenusName => "Opisthopterus";

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
