using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae.Hollardia;

/// <summary>
/// Abstract class for Hollardia (genus).
/// NCBI TaxId: 2898567
/// </summary>
public abstract class Hollardia : Triacanthodidae, IHollardia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hollardia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2898567;

    /// <inheritdoc />
    public virtual string GenusName => "Hollardia";

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
