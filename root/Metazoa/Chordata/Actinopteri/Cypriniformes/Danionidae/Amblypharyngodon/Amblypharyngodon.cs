using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Amblypharyngodon;

/// <summary>
/// Abstract class for Amblypharyngodon (genus).
/// NCBI TaxId: 38660
/// </summary>
public abstract class Amblypharyngodon : Danionidae, IAmblypharyngodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblypharyngodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38660;

    /// <inheritdoc />
    public virtual string GenusName => "Amblypharyngodon";

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
