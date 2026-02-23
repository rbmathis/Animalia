using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Hypselobarbus;

/// <summary>
/// Abstract class for Hypselobarbus (genus).
/// NCBI TaxId: 497004
/// </summary>
public abstract class Hypselobarbus : Cyprinidae, IHypselobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypselobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 497004;

    /// <inheritdoc />
    public virtual string GenusName => "Hypselobarbus";

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
