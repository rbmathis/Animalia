using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Serranocirrhitus;

/// <summary>
/// Abstract class for Serranocirrhitus (genus).
/// NCBI TaxId: 587070
/// </summary>
public abstract class Serranocirrhitus : Anthiadidae, ISerranocirrhitus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serranocirrhitus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 587070;

    /// <inheritdoc />
    public virtual string GenusName => "Serranocirrhitus";

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
