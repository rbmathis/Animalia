using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Cephalopholis;

/// <summary>
/// Abstract class for Cephalopholis (genus).
/// NCBI TaxId: 91742
/// </summary>
public abstract class Cephalopholis : Serranidae, ICephalopholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cephalopholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91742;

    /// <inheritdoc />
    public virtual string GenusName => "Cephalopholis";

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
