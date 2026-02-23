using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Ptychobarbus;

/// <summary>
/// Abstract class for Ptychobarbus (genus).
/// NCBI TaxId: 263524
/// </summary>
public abstract class Ptychobarbus : Cyprinidae, IPtychobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptychobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 263524;

    /// <inheritdoc />
    public virtual string GenusName => "Ptychobarbus";

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
