using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Centropristis;

/// <summary>
/// Abstract class for Centropristis (genus).
/// NCBI TaxId: 184439
/// </summary>
public abstract class Centropristis : Serranidae, ICentropristis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centropristis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 184439;

    /// <inheritdoc />
    public virtual string GenusName => "Centropristis";

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
