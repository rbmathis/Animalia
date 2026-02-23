using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Graphiurus;

/// <summary>
/// Abstract class for Graphiurus (genus).
/// NCBI TaxId: 51345
/// </summary>
public abstract class Graphiurus : Gliridae, IGraphiurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Graphiurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51345;

    /// <inheritdoc />
    public virtual string GenusName => "Graphiurus";

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
