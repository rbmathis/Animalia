using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Dipterygonotus;

/// <summary>
/// Abstract class for Dipterygonotus (genus).
/// NCBI TaxId: 182666
/// </summary>
public abstract class Dipterygonotus : Lutjanidae, IDipterygonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dipterygonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182666;

    /// <inheritdoc />
    public virtual string GenusName => "Dipterygonotus";

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
