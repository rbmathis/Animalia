using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Oreolalax;

/// <summary>
/// Abstract class for Oreolalax (genus).
/// NCBI TaxId: 265043
/// </summary>
public abstract class Oreolalax : Megophryidae, IOreolalax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreolalax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 265043;

    /// <inheritdoc />
    public virtual string GenusName => "Oreolalax";

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
