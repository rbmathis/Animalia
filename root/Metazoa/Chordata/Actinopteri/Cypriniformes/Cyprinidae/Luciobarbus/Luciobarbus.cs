using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Luciobarbus;

/// <summary>
/// Abstract class for Luciobarbus (genus).
/// NCBI TaxId: 933939
/// </summary>
public abstract class Luciobarbus : Cyprinidae, ILuciobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Luciobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 933939;

    /// <inheritdoc />
    public virtual string GenusName => "Luciobarbus";

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
