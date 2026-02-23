using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triacanthidae.Pseudotriacanthus;

/// <summary>
/// Abstract class for Pseudotriacanthus (genus).
/// NCBI TaxId: 428495
/// </summary>
public abstract class Pseudotriacanthus : Triacanthidae, IPseudotriacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudotriacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 428495;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudotriacanthus";

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
