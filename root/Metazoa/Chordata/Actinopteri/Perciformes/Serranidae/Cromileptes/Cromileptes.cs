using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Cromileptes;

/// <summary>
/// Abstract class for Cromileptes (genus).
/// NCBI TaxId: 304458
/// </summary>
public abstract class Cromileptes : Serranidae, ICromileptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cromileptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304458;

    /// <inheritdoc />
    public virtual string GenusName => "Cromileptes";

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
