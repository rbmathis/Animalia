using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Rhinelepis;

/// <summary>
/// Abstract class for Rhinelepis (genus).
/// NCBI TaxId: 745517
/// </summary>
public abstract class Rhinelepis : Loricariidae, IRhinelepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinelepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 745517;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinelepis";

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
