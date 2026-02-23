using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae.Parahollardia;

/// <summary>
/// Abstract class for Parahollardia (genus).
/// NCBI TaxId: 1311556
/// </summary>
public abstract class Parahollardia : Triacanthodidae, IParahollardia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parahollardia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311556;

    /// <inheritdoc />
    public virtual string GenusName => "Parahollardia";

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
