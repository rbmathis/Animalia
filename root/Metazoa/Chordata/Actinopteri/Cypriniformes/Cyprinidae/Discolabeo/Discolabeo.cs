using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Discolabeo;

/// <summary>
/// Abstract class for Discolabeo (genus).
/// NCBI TaxId: 887930
/// </summary>
public abstract class Discolabeo : Cyprinidae, IDiscolabeo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Discolabeo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 887930;

    /// <inheritdoc />
    public virtual string GenusName => "Discolabeo";

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
