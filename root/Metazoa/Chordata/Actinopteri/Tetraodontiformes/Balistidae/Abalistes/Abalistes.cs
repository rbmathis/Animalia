using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Balistidae.Abalistes;

/// <summary>
/// Abstract class for Abalistes (genus).
/// NCBI TaxId: 303702
/// </summary>
public abstract class Abalistes : Balistidae, IAbalistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Abalistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303702;

    /// <inheritdoc />
    public virtual string GenusName => "Abalistes";

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
