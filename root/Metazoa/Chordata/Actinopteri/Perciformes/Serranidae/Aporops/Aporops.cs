using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Aporops;

/// <summary>
/// Abstract class for Aporops (genus).
/// NCBI TaxId: 327783
/// </summary>
public abstract class Aporops : Serranidae, IAporops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aporops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 327783;

    /// <inheritdoc />
    public virtual string GenusName => "Aporops";

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
