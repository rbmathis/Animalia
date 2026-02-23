using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Prolabeo;

/// <summary>
/// Abstract class for Prolabeo (genus).
/// NCBI TaxId: 2860253
/// </summary>
public abstract class Prolabeo : Cyprinidae, IProlabeo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prolabeo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2860253;

    /// <inheritdoc />
    public virtual string GenusName => "Prolabeo";

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
