using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Dermatolepis;

/// <summary>
/// Abstract class for Dermatolepis (genus).
/// NCBI TaxId: 160711
/// </summary>
public abstract class Dermatolepis : Serranidae, IDermatolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dermatolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 160711;

    /// <inheritdoc />
    public virtual string GenusName => "Dermatolepis";

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
