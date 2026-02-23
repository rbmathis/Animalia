using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Brachymystax;

/// <summary>
/// Abstract class for Brachymystax (genus).
/// NCBI TaxId: 62066
/// </summary>
public abstract class Brachymystax : Salmonidae, IBrachymystax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachymystax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62066;

    /// <inheritdoc />
    public virtual string GenusName => "Brachymystax";

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
