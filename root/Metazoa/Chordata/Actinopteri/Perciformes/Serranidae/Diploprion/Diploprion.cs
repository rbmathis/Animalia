using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Diploprion;

/// <summary>
/// Abstract class for Diploprion (genus).
/// NCBI TaxId: 91746
/// </summary>
public abstract class Diploprion : Serranidae, IDiploprion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diploprion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91746;

    /// <inheritdoc />
    public virtual string GenusName => "Diploprion";

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
