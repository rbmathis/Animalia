using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Pseudobufo;

/// <summary>
/// Abstract class for Pseudobufo (genus).
/// NCBI TaxId: 1925437
/// </summary>
public abstract class Pseudobufo : Bufonidae, IPseudobufo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudobufo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1925437;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudobufo";

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
