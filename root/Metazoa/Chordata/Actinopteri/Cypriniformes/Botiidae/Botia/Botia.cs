using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Botia;

/// <summary>
/// Abstract class for Botia (genus).
/// NCBI TaxId: 98400
/// </summary>
public abstract class Botia : Botiidae, IBotia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Botia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98400;

    /// <inheritdoc />
    public virtual string GenusName => "Botia";

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
