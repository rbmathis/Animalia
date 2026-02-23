using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Cycloramphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Cycloramphidae.Thoropa;

/// <summary>
/// Abstract class for Thoropa (genus).
/// NCBI TaxId: 377347
/// </summary>
public abstract class Thoropa : Cycloramphidae, IThoropa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thoropa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 377347;

    /// <inheritdoc />
    public virtual string GenusName => "Thoropa";

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
