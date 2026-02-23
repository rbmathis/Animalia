using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthodidae.Paratriacanthodes;

/// <summary>
/// Abstract class for Paratriacanthodes (genus).
/// NCBI TaxId: 1414496
/// </summary>
public abstract class Paratriacanthodes : Triacanthodidae, IParatriacanthodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paratriacanthodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1414496;

    /// <inheritdoc />
    public virtual string GenusName => "Paratriacanthodes";

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
