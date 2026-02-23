using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Sinibotia;

/// <summary>
/// Abstract class for Sinibotia (genus).
/// NCBI TaxId: 322125
/// </summary>
public abstract class Sinibotia : Botiidae, ISinibotia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sinibotia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 322125;

    /// <inheritdoc />
    public virtual string GenusName => "Sinibotia";

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
