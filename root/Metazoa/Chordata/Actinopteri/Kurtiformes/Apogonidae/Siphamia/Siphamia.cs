using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Siphamia;

/// <summary>
/// Abstract class for Siphamia (genus).
/// NCBI TaxId: 397597
/// </summary>
public abstract class Siphamia : Apogonidae, ISiphamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siphamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 397597;

    /// <inheritdoc />
    public virtual string GenusName => "Siphamia";

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
