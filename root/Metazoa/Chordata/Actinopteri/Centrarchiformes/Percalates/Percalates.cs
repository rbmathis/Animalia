using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percalates;

/// <summary>
/// Abstract class for Percalates (genus).
/// NCBI TaxId: 1545907
/// </summary>
public abstract class Percalates : Centrarchiformes, IPercalates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Percalates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545907;

    /// <inheritdoc />
    public virtual string GenusName => "Percalates";

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
