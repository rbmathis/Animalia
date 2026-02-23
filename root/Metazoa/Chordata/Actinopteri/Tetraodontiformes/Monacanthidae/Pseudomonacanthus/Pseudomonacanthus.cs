using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Pseudomonacanthus;

/// <summary>
/// Abstract class for Pseudomonacanthus (genus).
/// NCBI TaxId: 392926
/// </summary>
public abstract class Pseudomonacanthus : Monacanthidae, IPseudomonacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudomonacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 392926;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudomonacanthus";

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
