using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Serraniculus;

/// <summary>
/// Abstract class for Serraniculus (genus).
/// NCBI TaxId: 451891
/// </summary>
public abstract class Serraniculus : Serranidae, ISerraniculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serraniculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 451891;

    /// <inheritdoc />
    public virtual string GenusName => "Serraniculus";

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
